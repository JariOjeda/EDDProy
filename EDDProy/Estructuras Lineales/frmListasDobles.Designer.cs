namespace EDDemo.Estructuras_Lineales
{
    partial class frmListasDobles
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
            this.BtRecorrerAtras = new System.Windows.Forms.Button();
            this.TxPosicion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.TxInPut = new System.Windows.Forms.TextBox();
            this.BtEliminarPosicion = new System.Windows.Forms.Button();
            this.BtBuscar = new System.Windows.Forms.Button();
            this.BtInsetarPosicion = new System.Windows.Forms.Button();
            this.TxResultado = new System.Windows.Forms.TextBox();
            this.BtListaDVaciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtRecorrerAtras
            // 
            this.BtRecorrerAtras.BackColor = System.Drawing.Color.DarkBlue;
            this.BtRecorrerAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtRecorrerAtras.ForeColor = System.Drawing.Color.White;
            this.BtRecorrerAtras.Location = new System.Drawing.Point(614, 147);
            this.BtRecorrerAtras.Name = "BtRecorrerAtras";
            this.BtRecorrerAtras.Size = new System.Drawing.Size(120, 42);
            this.BtRecorrerAtras.TabIndex = 89;
            this.BtRecorrerAtras.Text = "Recorrer hacia atras";
            this.BtRecorrerAtras.UseVisualStyleBackColor = false;
            this.BtRecorrerAtras.Click += new System.EventHandler(this.BtRecorrerAtras_Click);
            // 
            // TxPosicion
            // 
            this.TxPosicion.Location = new System.Drawing.Point(594, 110);
            this.TxPosicion.Name = "TxPosicion";
            this.TxPosicion.Size = new System.Drawing.Size(164, 20);
            this.TxPosicion.TabIndex = 88;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(644, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 87;
            this.label3.Text = "Posicion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 86;
            this.label2.Text = "Informacion";
            // 
            // TxInfo
            // 
            this.TxInfo.Location = new System.Drawing.Point(423, 356);
            this.TxInfo.Multiline = true;
            this.TxInfo.Name = "TxInfo";
            this.TxInfo.Size = new System.Drawing.Size(232, 63);
            this.TxInfo.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(495, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 84;
            this.label1.Text = "Dato";
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(121, 42);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(158, 25);
            this.Titulo.TabIndex = 83;
            this.Titulo.Text = "LISTA DOBLE";
            // 
            // TxInPut
            // 
            this.TxInPut.Location = new System.Drawing.Point(432, 110);
            this.TxInPut.Name = "TxInPut";
            this.TxInPut.Size = new System.Drawing.Size(152, 20);
            this.TxInPut.TabIndex = 82;
            // 
            // BtEliminarPosicion
            // 
            this.BtEliminarPosicion.BackColor = System.Drawing.Color.DarkBlue;
            this.BtEliminarPosicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEliminarPosicion.ForeColor = System.Drawing.Color.White;
            this.BtEliminarPosicion.Location = new System.Drawing.Point(433, 195);
            this.BtEliminarPosicion.Name = "BtEliminarPosicion";
            this.BtEliminarPosicion.Size = new System.Drawing.Size(119, 42);
            this.BtEliminarPosicion.TabIndex = 81;
            this.BtEliminarPosicion.Text = "Eliminar una posicion";
            this.BtEliminarPosicion.UseVisualStyleBackColor = false;
            this.BtEliminarPosicion.Click += new System.EventHandler(this.BtEliminarPosicion_Click);
            // 
            // BtBuscar
            // 
            this.BtBuscar.BackColor = System.Drawing.Color.DarkBlue;
            this.BtBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtBuscar.ForeColor = System.Drawing.Color.White;
            this.BtBuscar.Location = new System.Drawing.Point(614, 195);
            this.BtBuscar.Name = "BtBuscar";
            this.BtBuscar.Size = new System.Drawing.Size(120, 42);
            this.BtBuscar.TabIndex = 80;
            this.BtBuscar.Text = "Buscar";
            this.BtBuscar.UseVisualStyleBackColor = false;
            this.BtBuscar.Click += new System.EventHandler(this.BtBuscar_Click);
            // 
            // BtInsetarPosicion
            // 
            this.BtInsetarPosicion.BackColor = System.Drawing.Color.DarkBlue;
            this.BtInsetarPosicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtInsetarPosicion.ForeColor = System.Drawing.Color.White;
            this.BtInsetarPosicion.Location = new System.Drawing.Point(432, 147);
            this.BtInsetarPosicion.Name = "BtInsetarPosicion";
            this.BtInsetarPosicion.Size = new System.Drawing.Size(120, 42);
            this.BtInsetarPosicion.TabIndex = 79;
            this.BtInsetarPosicion.Text = "Insetar en posicion";
            this.BtInsetarPosicion.UseVisualStyleBackColor = false;
            this.BtInsetarPosicion.Click += new System.EventHandler(this.BtInsetarPosicion_Click);
            // 
            // TxResultado
            // 
            this.TxResultado.Location = new System.Drawing.Point(40, 70);
            this.TxResultado.Multiline = true;
            this.TxResultado.Name = "TxResultado";
            this.TxResultado.Size = new System.Drawing.Size(328, 349);
            this.TxResultado.TabIndex = 78;
            // 
            // BtListaDVaciar
            // 
            this.BtListaDVaciar.BackColor = System.Drawing.Color.DarkBlue;
            this.BtListaDVaciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtListaDVaciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtListaDVaciar.ForeColor = System.Drawing.Color.White;
            this.BtListaDVaciar.Location = new System.Drawing.Point(691, 369);
            this.BtListaDVaciar.Name = "BtListaDVaciar";
            this.BtListaDVaciar.Size = new System.Drawing.Size(67, 35);
            this.BtListaDVaciar.TabIndex = 77;
            this.BtListaDVaciar.Text = "Vaciar";
            this.BtListaDVaciar.UseVisualStyleBackColor = false;
            this.BtListaDVaciar.Click += new System.EventHandler(this.BtListaDVaciar_Click);
            // 
            // frmListasDobles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtRecorrerAtras);
            this.Controls.Add(this.TxPosicion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.TxInPut);
            this.Controls.Add(this.BtEliminarPosicion);
            this.Controls.Add(this.BtBuscar);
            this.Controls.Add(this.BtInsetarPosicion);
            this.Controls.Add(this.TxResultado);
            this.Controls.Add(this.BtListaDVaciar);
            this.Name = "frmListasDobles";
            this.Text = "frmListasDobles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtRecorrerAtras;
        private System.Windows.Forms.TextBox TxPosicion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.TextBox TxInPut;
        private System.Windows.Forms.Button BtEliminarPosicion;
        private System.Windows.Forms.Button BtBuscar;
        private System.Windows.Forms.Button BtInsetarPosicion;
        private System.Windows.Forms.TextBox TxResultado;
        private System.Windows.Forms.Button BtListaDVaciar;
    }
}