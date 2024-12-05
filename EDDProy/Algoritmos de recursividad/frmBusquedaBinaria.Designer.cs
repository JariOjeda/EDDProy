namespace EDDemo.Algoritmos_de_recursividad
{
    partial class FrmBusquedaBinaria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TituloBusquedaBinaria = new System.Windows.Forms.Label();
            this.ResultadoIndicesTxtBox = new System.Windows.Forms.TextBox();
            this.btBuscarEnArreglo = new System.Windows.Forms.Button();
            this.PedirNumeroBusquedaBinaria = new System.Windows.Forms.Label();
            this.PedirNumeroBusquedaTxtBox = new System.Windows.Forms.TextBox();
            this.ResultadoGenerarArregloTxtBox = new System.Windows.Forms.TextBox();
            this.btGenerarArreglo = new System.Windows.Forms.Button();
            this.PedirElementosBusquedaBinaria = new System.Windows.Forms.Label();
            this.EscribirNumElementosBusquedaTxtBox = new System.Windows.Forms.TextBox();
            this.LblTiempo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TituloBusquedaBinaria
            // 
            this.TituloBusquedaBinaria.AutoSize = true;
            this.TituloBusquedaBinaria.BackColor = System.Drawing.SystemColors.Control;
            this.TituloBusquedaBinaria.Cursor = System.Windows.Forms.Cursors.Default;
            this.TituloBusquedaBinaria.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloBusquedaBinaria.ForeColor = System.Drawing.Color.DarkBlue;
            this.TituloBusquedaBinaria.Location = new System.Drawing.Point(12, 9);
            this.TituloBusquedaBinaria.Name = "TituloBusquedaBinaria";
            this.TituloBusquedaBinaria.Size = new System.Drawing.Size(281, 45);
            this.TituloBusquedaBinaria.TabIndex = 38;
            this.TituloBusquedaBinaria.Text = "Busqueda Binaria";
            // 
            // ResultadoIndicesTxtBox
            // 
            this.ResultadoIndicesTxtBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultadoIndicesTxtBox.Location = new System.Drawing.Point(175, 308);
            this.ResultadoIndicesTxtBox.Name = "ResultadoIndicesTxtBox";
            this.ResultadoIndicesTxtBox.Size = new System.Drawing.Size(332, 25);
            this.ResultadoIndicesTxtBox.TabIndex = 48;
            // 
            // btBuscarEnArreglo
            // 
            this.btBuscarEnArreglo.BackColor = System.Drawing.Color.DarkBlue;
            this.btBuscarEnArreglo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBuscarEnArreglo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscarEnArreglo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscarEnArreglo.ForeColor = System.Drawing.Color.White;
            this.btBuscarEnArreglo.Location = new System.Drawing.Point(19, 308);
            this.btBuscarEnArreglo.Name = "btBuscarEnArreglo";
            this.btBuscarEnArreglo.Size = new System.Drawing.Size(136, 34);
            this.btBuscarEnArreglo.TabIndex = 47;
            this.btBuscarEnArreglo.Text = "Buscar";
            this.btBuscarEnArreglo.UseVisualStyleBackColor = false;
            this.btBuscarEnArreglo.Click += new System.EventHandler(this.btBuscarEnArreglo_Click);
            // 
            // PedirNumeroBusquedaBinaria
            // 
            this.PedirNumeroBusquedaBinaria.AutoSize = true;
            this.PedirNumeroBusquedaBinaria.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PedirNumeroBusquedaBinaria.Location = new System.Drawing.Point(15, 248);
            this.PedirNumeroBusquedaBinaria.Name = "PedirNumeroBusquedaBinaria";
            this.PedirNumeroBusquedaBinaria.Size = new System.Drawing.Size(395, 21);
            this.PedirNumeroBusquedaBinaria.TabIndex = 46;
            this.PedirNumeroBusquedaBinaria.Text = "Selecciona un numero del 1 al 1000 que quieras bucar";
            // 
            // PedirNumeroBusquedaTxtBox
            // 
            this.PedirNumeroBusquedaTxtBox.Location = new System.Drawing.Point(19, 272);
            this.PedirNumeroBusquedaTxtBox.Name = "PedirNumeroBusquedaTxtBox";
            this.PedirNumeroBusquedaTxtBox.Size = new System.Drawing.Size(136, 20);
            this.PedirNumeroBusquedaTxtBox.TabIndex = 45;
            // 
            // ResultadoGenerarArregloTxtBox
            // 
            this.ResultadoGenerarArregloTxtBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultadoGenerarArregloTxtBox.Location = new System.Drawing.Point(175, 182);
            this.ResultadoGenerarArregloTxtBox.Name = "ResultadoGenerarArregloTxtBox";
            this.ResultadoGenerarArregloTxtBox.Size = new System.Drawing.Size(332, 25);
            this.ResultadoGenerarArregloTxtBox.TabIndex = 44;
            // 
            // btGenerarArreglo
            // 
            this.btGenerarArreglo.BackColor = System.Drawing.Color.DarkBlue;
            this.btGenerarArreglo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGenerarArreglo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGenerarArreglo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGenerarArreglo.ForeColor = System.Drawing.Color.White;
            this.btGenerarArreglo.Location = new System.Drawing.Point(19, 175);
            this.btGenerarArreglo.Name = "btGenerarArreglo";
            this.btGenerarArreglo.Size = new System.Drawing.Size(136, 34);
            this.btGenerarArreglo.TabIndex = 43;
            this.btGenerarArreglo.Text = "Generar Arreglo";
            this.btGenerarArreglo.UseVisualStyleBackColor = false;
            this.btGenerarArreglo.Click += new System.EventHandler(this.btGenerarArreglo_Click);
            // 
            // PedirElementosBusquedaBinaria
            // 
            this.PedirElementosBusquedaBinaria.AutoSize = true;
            this.PedirElementosBusquedaBinaria.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PedirElementosBusquedaBinaria.Location = new System.Drawing.Point(15, 118);
            this.PedirElementosBusquedaBinaria.Name = "PedirElementosBusquedaBinaria";
            this.PedirElementosBusquedaBinaria.Size = new System.Drawing.Size(328, 21);
            this.PedirElementosBusquedaBinaria.TabIndex = 42;
            this.PedirElementosBusquedaBinaria.Text = "Escribe el numero de elementos del arreglo";
            // 
            // EscribirNumElementosBusquedaTxtBox
            // 
            this.EscribirNumElementosBusquedaTxtBox.Location = new System.Drawing.Point(19, 142);
            this.EscribirNumElementosBusquedaTxtBox.Name = "EscribirNumElementosBusquedaTxtBox";
            this.EscribirNumElementosBusquedaTxtBox.Size = new System.Drawing.Size(136, 20);
            this.EscribirNumElementosBusquedaTxtBox.TabIndex = 41;
            // 
            // LblTiempo
            // 
            this.LblTiempo.AutoSize = true;
            this.LblTiempo.Location = new System.Drawing.Point(36, 411);
            this.LblTiempo.Name = "LblTiempo";
            this.LblTiempo.Size = new System.Drawing.Size(42, 13);
            this.LblTiempo.TabIndex = 49;
            this.LblTiempo.Text = "Tiempo";
            // 
            // FrmBusquedaBinaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblTiempo);
            this.Controls.Add(this.ResultadoIndicesTxtBox);
            this.Controls.Add(this.btBuscarEnArreglo);
            this.Controls.Add(this.PedirNumeroBusquedaBinaria);
            this.Controls.Add(this.PedirNumeroBusquedaTxtBox);
            this.Controls.Add(this.ResultadoGenerarArregloTxtBox);
            this.Controls.Add(this.btGenerarArreglo);
            this.Controls.Add(this.PedirElementosBusquedaBinaria);
            this.Controls.Add(this.EscribirNumElementosBusquedaTxtBox);
            this.Controls.Add(this.TituloBusquedaBinaria);
            this.Name = "FrmBusquedaBinaria";
            this.Text = "frmBusquedaBinaria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TituloBusquedaBinaria;
        private System.Windows.Forms.TextBox ResultadoIndicesTxtBox;
        private System.Windows.Forms.Button btBuscarEnArreglo;
        private System.Windows.Forms.Label PedirNumeroBusquedaBinaria;
        private System.Windows.Forms.TextBox PedirNumeroBusquedaTxtBox;
        private System.Windows.Forms.TextBox ResultadoGenerarArregloTxtBox;
        private System.Windows.Forms.Button btGenerarArreglo;
        private System.Windows.Forms.Label PedirElementosBusquedaBinaria;
        private System.Windows.Forms.TextBox EscribirNumElementosBusquedaTxtBox;
        private System.Windows.Forms.Label LblTiempo;
    }
}