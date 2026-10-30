# 🧭 FiyiCompassDB

Herramienta de escritorio para comparar la estructura de dos bases de datos **Microsoft SQL Server** y detectar objetos que faltan en una base respecto de otra.

## 🎯 Propósito

FiyiCompassDB ayuda a revisar diferencias de esquema entre una base de datos de referencia (la **BD pivote**) y una base destino (la **BD a analizar**). Es útil, por ejemplo, para comprobar si una base de desarrollo, pruebas o producción contiene los objetos esperados antes de continuar con una revisión o despliegue.

El análisis informa:

- 🗃️ Tablas de la BD pivote que no existen en la BD analizada, comparando esquema y nombre.
- 🧱 Columnas faltantes en las tablas que existen en ambas bases.
- ⚙️ Procedimientos almacenados de la BD pivote que no aparecen en la BD analizada.

El programa genera un reporte en pantalla: **no modifica las bases de datos, no sincroniza esquemas ni crea scripts de migración**. La comparación de columnas se limita a su presencia por nombre; no valida diferencias de tipo, nulabilidad, índices, claves ni definiciones de procedimientos.

## 🛠️ Tecnología

- 🪟 **C# y Windows Forms** para la interfaz gráfica de escritorio.
- 💻 **.NET 8** (`net8.0-windows`) como plataforma de la aplicación.
- 🗄️ **Microsoft SQL Server** como motor de las bases inspeccionadas.
- 🔌 **Dapper** para ejecutar consultas/procedimientos y mapear resultados.
- 📦 **FiyiStack.Library** para encapsular el acceso a SQL Server y los modelos de tablas y columnas. La biblioteca usa `Microsoft.Data.SqlClient`.

## 🚀 Requisitos y ejecución

1. Utiliza Windows con el **.NET 8 SDK** instalado.
2. Asegúrate de tener acceso de red a ambas instancias SQL Server y credenciales con permisos para consultar los metadatos requeridos.
3. Configura para cada base su nombre y cadena de conexión en la aplicación. Los botones **LocalHost** y **Production** cargan plantillas; revisa y completa sus valores antes de analizar.
4. Desde la raíz del repositorio, ejecuta:

   ```powershell
   dotnet run --project .\FiyiCompassDB\FiyiCompassDB.csproj
   ```

   También puedes abrir `FiyiCompassDB.sln` con Visual Studio y ejecutar el proyecto `FiyiCompassDB`.

## 🔍 Cómo funciona

1. Comprueba que ambas bases existan.
2. Obtiene tablas, columnas y procedimientos almacenados de cada base.
3. Compara los objetos de la BD pivote con los de la BD analizada.
4. Muestra los elementos faltantes en el área **Resultados**.

La biblioteca compartida obtiene parte de los metadatos mediante procedimientos almacenados `CommonFunctions.MSSQLServer` (por ejemplo, para verificar bases y listar tablas y columnas). Verifica que esos procedimientos estén disponibles y que el usuario configurado pueda ejecutarlos. La lista de procedimientos almacenados también se consulta desde `INFORMATION_SCHEMA.ROUTINES`.
