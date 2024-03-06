namespace FiyiCompDB
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            label1 = new Label();
            txtConnectionStringBDAAnalizar = new TextBox();
            label2 = new Label();
            txtResult = new TextBox();
            label3 = new Label();
            btnAnalizar = new Button();
            btnLocalHost = new Button();
            btnProduction = new Button();
            txtConnectionStringBDPivote = new TextBox();
            txtDBNamePivote = new TextBox();
            txtDBNameAAnalizar = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(57, 210, 221);
            label1.Location = new Point(39, 114);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 0;
            label1.Text = "ConnectionString";
            // 
            // txtConnectionStringBDAAnalizar
            // 
            txtConnectionStringBDAAnalizar.BackColor = Color.FromArgb(32, 38, 44);
            txtConnectionStringBDAAnalizar.ForeColor = Color.FromArgb(57, 210, 221);
            txtConnectionStringBDAAnalizar.Location = new Point(428, 137);
            txtConnectionStringBDAAnalizar.Multiline = true;
            txtConnectionStringBDAAnalizar.Name = "txtConnectionStringBDAAnalizar";
            txtConnectionStringBDAAnalizar.ScrollBars = ScrollBars.Both;
            txtConnectionStringBDAAnalizar.Size = new Size(337, 130);
            txtConnectionStringBDAAnalizar.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(57, 210, 221);
            label2.Location = new Point(428, 114);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 3;
            label2.Text = "ConnectionString";
            // 
            // txtResult
            // 
            txtResult.BackColor = Color.FromArgb(32, 38, 44);
            txtResult.ForeColor = Color.FromArgb(57, 210, 221);
            txtResult.Location = new Point(39, 371);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ScrollBars = ScrollBars.Both;
            txtResult.Size = new Size(726, 220);
            txtResult.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(57, 210, 221);
            label3.Location = new Point(39, 348);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 5;
            label3.Text = "Resultados";
            // 
            // btnAnalizar
            // 
            btnAnalizar.BackColor = Color.FromArgb(32, 38, 44);
            btnAnalizar.ForeColor = Color.FromArgb(57, 210, 221);
            btnAnalizar.Location = new Point(617, 316);
            btnAnalizar.Name = "btnAnalizar";
            btnAnalizar.Size = new Size(148, 49);
            btnAnalizar.TabIndex = 6;
            btnAnalizar.Text = "Analizar";
            btnAnalizar.UseVisualStyleBackColor = false;
            btnAnalizar.Click += btnAnalizar_Click;
            // 
            // btnLocalHost
            // 
            btnLocalHost.BackColor = Color.FromArgb(32, 38, 44);
            btnLocalHost.ForeColor = Color.FromArgb(57, 210, 221);
            btnLocalHost.Location = new Point(39, 273);
            btnLocalHost.Name = "btnLocalHost";
            btnLocalHost.Size = new Size(89, 49);
            btnLocalHost.TabIndex = 7;
            btnLocalHost.Text = "LocalHost";
            btnLocalHost.UseVisualStyleBackColor = false;
            btnLocalHost.Click += btnLocalHost_Click;
            // 
            // btnProduction
            // 
            btnProduction.BackColor = Color.FromArgb(32, 38, 44);
            btnProduction.ForeColor = Color.FromArgb(57, 210, 221);
            btnProduction.Location = new Point(134, 273);
            btnProduction.Name = "btnProduction";
            btnProduction.Size = new Size(89, 49);
            btnProduction.TabIndex = 8;
            btnProduction.Text = "Production";
            btnProduction.UseVisualStyleBackColor = false;
            btnProduction.Click += btnProduction_Click;
            // 
            // txtConnectionStringBDPivote
            // 
            txtConnectionStringBDPivote.BackColor = Color.FromArgb(32, 38, 44);
            txtConnectionStringBDPivote.ForeColor = Color.FromArgb(57, 210, 221);
            txtConnectionStringBDPivote.Location = new Point(39, 137);
            txtConnectionStringBDPivote.Multiline = true;
            txtConnectionStringBDPivote.Name = "txtConnectionStringBDPivote";
            txtConnectionStringBDPivote.ScrollBars = ScrollBars.Both;
            txtConnectionStringBDPivote.Size = new Size(337, 130);
            txtConnectionStringBDPivote.TabIndex = 1;
            // 
            // txtDBNamePivote
            // 
            txtDBNamePivote.BackColor = Color.FromArgb(32, 38, 44);
            txtDBNamePivote.ForeColor = Color.FromArgb(57, 210, 221);
            txtDBNamePivote.Location = new Point(39, 84);
            txtDBNamePivote.Name = "txtDBNamePivote";
            txtDBNamePivote.Size = new Size(337, 27);
            txtDBNamePivote.TabIndex = 9;
            // 
            // txtDBNameAAnalizar
            // 
            txtDBNameAAnalizar.BackColor = Color.FromArgb(32, 38, 44);
            txtDBNameAAnalizar.ForeColor = Color.FromArgb(57, 210, 221);
            txtDBNameAAnalizar.Location = new Point(428, 84);
            txtDBNameAAnalizar.Name = "txtDBNameAAnalizar";
            txtDBNameAAnalizar.Size = new Size(337, 27);
            txtDBNameAAnalizar.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(57, 210, 221);
            label4.Location = new Point(39, 61);
            label4.Name = "label4";
            label4.Size = new Size(125, 20);
            label4.TabIndex = 11;
            label4.Text = "Nombre de la BD";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(57, 210, 221);
            label5.Location = new Point(428, 30);
            label5.Name = "label5";
            label5.Size = new Size(268, 31);
            label5.TabIndex = 12;
            label5.Text = "Base de datos a analizar";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(57, 210, 221);
            label6.Location = new Point(39, 30);
            label6.Name = "label6";
            label6.Size = new Size(234, 31);
            label6.TabIndex = 13;
            label6.Text = "Base de datos pivote";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(57, 210, 221);
            label7.Location = new Point(428, 61);
            label7.Name = "label7";
            label7.Size = new Size(125, 20);
            label7.TabIndex = 14;
            label7.Text = "Nombre de la BD";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 48, 57);
            ClientSize = new Size(800, 619);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtDBNameAAnalizar);
            Controls.Add(txtDBNamePivote);
            Controls.Add(btnProduction);
            Controls.Add(btnLocalHost);
            Controls.Add(btnAnalizar);
            Controls.Add(label3);
            Controls.Add(txtResult);
            Controls.Add(label2);
            Controls.Add(txtConnectionStringBDAAnalizar);
            Controls.Add(txtConnectionStringBDPivote);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "FiyiCompassDB";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtConnectionStringBDAAnalizar;
        private Label label2;
        private TextBox txtResult;
        private Label label3;
        private Button btnAnalizar;
        private Button btnLocalHost;
        private Button btnProduction;
        private TextBox txtConnectionStringBDPivote;
        private TextBox txtDBNamePivote;
        private TextBox txtDBNameAAnalizar;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
