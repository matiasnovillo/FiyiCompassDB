using Microsoft.Win32;

namespace FiyiCompDB
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();


#if DEBUG
            txtDBNamePivote.Text = "fiyistack_FiyiRequirements";
            txtDBNameAAnalizar.Text = "fiyistack_MarshallStore";

            txtConnectionStringBDPivote.Text = "data source =.;initial catalog=fiyistack_FiyiRequirements;Integrated Security = SSPI;MultipleActiveResultSets=True;Pooling=false;persist security info=True;App=EntityFramework;TrustServerCertificate=True;";

            txtConnectionStringBDAAnalizar.Text = "data source =.;initial catalog=fiyistack_MarshallStore;Integrated Security = SSPI;MultipleActiveResultSets=True;Pooling=false;persist security info=True;App=EntityFramework;TrustServerCertificate=True;";
#else
            txtConnectionStringBDPivote.Text = "data source =.;initial catalog=[PUT_A_DATABASE_NAME];Integrated Security = SSPI;MultipleActiveResultSets=True;Pooling=false;persist security info=True;App=EntityFramework;TrustServerCertificate=True";

            txtConnectionStringBDAAnalizar.Text = "data source =.;initial catalog=[PUT_A_DATABASE_NAME];Integrated Security = SSPI;MultipleActiveResultSets=True;Pooling=false;persist security info=True;App=EntityFramework;TrustServerCertificate=True";
#endif

        }

        private void btnAnalizar_Click(object sender, EventArgs e)
        {
            //Basico
            txtResult.Text = "";

            //Validaciones
            FiyiStack.Library.MicrosoftSQLServer.DataBase DataBase = new();
            if(!DataBase.ExistDataBase(txtConnectionStringBDPivote.Text, txtDBNamePivote.Text))
            {
                txtResult.Text = $@"La base de datos pivote, {txtDBNamePivote.Text}, no existe";
                return;
            }
            if(!DataBase.ExistDataBase(txtConnectionStringBDAAnalizar.Text, txtDBNameAAnalizar.Text))
            {
                txtResult.Text = $@"La base de datos a analizar, {txtDBNameAAnalizar.Text}, no existe";
                return;
            }

            txtResult.Text = $@"Analizando...

1. TABLAS FALTANTES

";

            #region TABLAS
            //Obtener tablas de la BD Pivote
            List<FiyiStack.Library.MicrosoftSQLServer.Table> lstTablePivote = new FiyiStack.Library.MicrosoftSQLServer.Table()
                .GetAllTablesByDataBaseNameToModel(txtConnectionStringBDPivote.Text, txtDBNamePivote.Text);

            //Obtener tablas de la BD a analizar
            List<FiyiStack.Library.MicrosoftSQLServer.Table> lstTableAAnalizar = new FiyiStack.Library.MicrosoftSQLServer.Table()
                .GetAllTablesByDataBaseNameToModel(txtConnectionStringBDAAnalizar.Text, txtDBNameAAnalizar.Text);


            List<FiyiStack.Library.MicrosoftSQLServer.Table> lstFaltantes = [];

            foreach (var tablaDePivote in lstTablePivote)
            {
                bool encontrado = false;
                foreach (var tablaDeTablaAAnalizar in lstTableAAnalizar)
                {
                    // Compara los registros
                    if (tablaDePivote.Name == tablaDeTablaAAnalizar.Name &&
                        tablaDePivote.Scheme == tablaDeTablaAAnalizar.Scheme)
                    {
                        encontrado = true;
                        break;
                    }
                }
                // Si el registro no se encuentra en la segunda lista, añádelo a las filas faltantes
                if (!encontrado)
                {
                    lstFaltantes.Add(tablaDePivote);
                }
            }

            txtResult.Text += $@"La tabla pivote, {txtDBNamePivote.Text}, contiene un total de {lstTablePivote.Count}.
La tabla a analizar, {txtDBNameAAnalizar.Text}, contiene un total de {lstTableAAnalizar.Count}.

";

            if (lstFaltantes.Count > 0)
            {
                txtResult.Text += $@"Las siguientes tablas no existen en la base de datos a analizar:

";
                foreach (FiyiStack.Library.MicrosoftSQLServer.Table tablaFaltante in lstFaltantes)
                {
                    txtResult.Text += $@"{tablaFaltante.Scheme}.{tablaFaltante.Name}

";
                }
            }
            else
            {
                txtResult.Text += $@"Todas las tablas de la base de datos pivote existen en la base de datos a analizar

";
            }
            #endregion

            #region COLUMNAS
            txtResult.Text += $@"

2. COLUMNAS FALTANTES

";

            //Crear una lista de tablas iguales de ambas BDs
            List<FiyiStack.Library.MicrosoftSQLServer.Table> lstTablasIguales = [];

            // Comparar las listas utilizando un bucle for
            foreach (var tablaDePivote in lstTablePivote)
            {
                foreach (var tablaDeTablaAAnalizar in lstTableAAnalizar)
                {
                    // Compara los registros
                    if (tablaDePivote.Name == tablaDeTablaAAnalizar.Name &&
                        tablaDePivote.Scheme == tablaDeTablaAAnalizar.Scheme)
                    {
                        // Si los registros son iguales, añádelo a la lista lstTablasIguales
                        lstTablasIguales.Add(tablaDePivote);
                        break; // Sal del bucle interno
                    }
                }
            }

            if (lstTablasIguales.Count == 0)
            {
                
            }
            else 
            { 
                foreach (var tablaAConsultar in lstTablasIguales)
                {

//                    txtResult.Text += $@"Consultando tabla {tablaAConsultar.Scheme}{tablaAConsultar.Name}:

//";

                    //Obtener tablas/columnas de la BD Pivote
                    List<FiyiStack.Library.MicrosoftSQLServer.Field> lstFieldPivote = new FiyiStack.Library.MicrosoftSQLServer.Field()
                        .GetAllFieldsByTableNameBySchemeNameToModel(txtConnectionStringBDPivote.Text, 
                        tablaAConsultar.Name,
                        tablaAConsultar.Scheme);

                    //Obtener tablas/columnas de la BD a analizar
                    List<FiyiStack.Library.MicrosoftSQLServer.Field> lstFieldAAnalizar = new FiyiStack.Library.MicrosoftSQLServer.Field()
                        .GetAllFieldsByTableNameBySchemeNameToModel(txtConnectionStringBDAAnalizar.Text,
                        tablaAConsultar.Name,
                        tablaAConsultar.Scheme);

                    // Crear una lista para almacenar las columnas faltantes en la BD a analizar
                    List<FiyiStack.Library.MicrosoftSQLServer.Field> lstFilasFaltantes = [];

                    // Comparar las listas lstFieldPivote y lstFieldAAnalizar utilizando un bucle for
                    foreach (var fieldPivote in lstFieldPivote)
                    {
                        bool encontrado = false;
                        foreach (var fieldAAnalizar in lstFieldAAnalizar)
                        {
                            // Compara los registros
                            if (fieldPivote.Name == fieldAAnalizar.Name)
                            {
                                encontrado = true;
                                break;
                            }
                        }
                        // Si el registro no se encuentra en la segunda lista, añádelo a las filas faltantes
                        if (!encontrado)
                        {
                            lstFilasFaltantes.Add(fieldPivote);
                        }
                    }

                    if (lstFilasFaltantes.Count == 0)
                    {
//                        txtResult.Text += $@"La tabla (repetida en ambas BDs), {tablaAConsultar.Scheme}{tablaAConsultar.Name}, contiene las mismas columnas.

//";
                    }
                    else
                    {
                        txtResult.Text += $@"La tabla (repetida en ambas BDs), {tablaAConsultar.Scheme}{tablaAConsultar.Name}, contiene las siguientes columnas faltantes en la BD analizada:
";

                        foreach (var filaFaltante in lstFilasFaltantes)
                        {
                            txtResult.Text += $@"{filaFaltante.Name}
";
                        }
                    }
                }
            }
            #endregion
        }

        private void btnLocalHost_Click(object sender, EventArgs e)
        {
            txtConnectionStringBDPivote.Text = "data source =.;initial catalog=[PUT_A_DATABASE_NAME];Integrated Security = SSPI;MultipleActiveResultSets=True;Pooling=false;persist security info=True;App=EntityFramework;TrustServerCertificate=True";

            txtConnectionStringBDAAnalizar.Text = "data source =.;initial catalog=[PUT_A_DATABASE_NAME];Integrated Security = SSPI;MultipleActiveResultSets=True;Pooling=false;persist security info=True;App=EntityFramework;TrustServerCertificate=True";
        }

        private void btnProduction_Click(object sender, EventArgs e)
        {
            txtConnectionStringBDPivote.Text = "Password=[PUT_A_PASSWORD];Persist Security Info=True;User ID=[PUT_A_USER_ID];Initial Catalog=[PUT_A_DATABASE_NAME];Data Source=[PUT_A_SOURCE_(SERVER)];TrustServerCertificate=True";
            
            txtConnectionStringBDAAnalizar.Text = "Password=[PUT_A_PASSWORD];Persist Security Info=True;User ID=[PUT_A_USER_ID];Initial Catalog=[PUT_A_DATABASE_NAME];Data Source=[PUT_A_SOURCE_(SERVER)];TrustServerCertificate=True";
        }
    }
}
