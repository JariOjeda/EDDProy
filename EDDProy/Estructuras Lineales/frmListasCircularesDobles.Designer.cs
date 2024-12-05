namespace EDDemo.Estructuras_Lineales
{
    partial class frmListasCircularesDobles
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
            this.BtListaCDVaciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxPosicion
            // 
            this.TxPosicion.Location = new System.Drawing.Point(583, 105);
            this.TxPosicion.Name = "TxPosicion";
            this.TxPosicion.Size = new System.Drawing.Size(164, 20);
            this.TxPosicion.TabIndex = 110;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(633, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 109;
            this.label3.Text = "Posicion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 108;
            this.label2.Text = "Informacion";
            // 
            // TxInfo
            // 
            this.TxInfo.Location = new System.Drawing.Point(423, 345);
            this.TxInfo.Multiline = true;
            this.TxInfo.Name = "TxInfo";
            this.TxInfo.Size = new System.Drawing.Size(230, 63);
            this.TxInfo.TabIndex = 107;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(484, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 106;
            this.label1.Text = "Dato";
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(57, 31);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(279, 25);
            this.Titulo.TabIndex = 105;
            this.Titulo.Text = "LISTA CIRCULAR DOBLE";
            // 
            // TxInPut
            // 
            this.TxInPut.Location = new System.Drawing.Point(421, 105);
            this.TxInPut.Name = "TxInPut";
            this.TxInPut.Size = new System.Drawing.Size(152, 20);
            this.TxInPut.TabIndex = 104;
            // 
            // BtEliminarPosicion
            // 
            this.BtEliminarPosicion.BackColor = System.Drawing.Color.DarkBlue;
            this.BtEliminarPosicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEliminarPosicion.ForeColor = System.Drawing.Color.White;
            this.BtEliminarPosicion.Location = new System.Drawing.Point(516, 190);
            this.BtEliminarPosicion.Name = "BtEliminarPosicion";
            this.BtEliminarPosicion.Size = new System.Drawing.Size(124, 49);
            this.BtEliminarPosicion.TabIndex = 103;
            this.BtEliminarPosicion.Text = "Eliminar una posicion";
            this.BtEliminarPosicion.UseVisualStyleBackColor = false;
            this.BtEliminarPosicion.Click += new System.EventHandler(this.BtEliminarPosicion_Click);
            // 
            // BtBuscar
            // 
            this.BtBuscar.BackColor = System.Drawing.Color.DarkBlue;
            this.BtBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtBuscar.ForeColor = System.Drawing.Color.White;
            this.BtBuscar.Location = new System.Drawing.Point(515, 245);
            this.BtBuscar.Name = "BtBuscar";
            this.BtBuscar.Size = new System.Drawing.Size(125, 45);
            this.BtBuscar.TabIndex = 102;
            this.BtBuscar.Text = "Buscar";
            this.BtBuscar.UseVisualStyleBackColor = false;
            this.BtBuscar.Click += new System.EventHandler(this.BtBuscar_Click);
            // 
            // BtInsetarPosicion
            // 
            this.BtInsetarPosicion.BackColor = System.Drawing.Color.DarkBlue;
            this.BtInsetarPosicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtInsetarPosicion.ForeColor = System.Drawing.Color.White;
            this.BtInsetarPosicion.Location = new System.Drawing.Point(515, 142);
            this.BtInsetarPosicion.Name = "BtInsetarPosicion";
            this.BtInsetarPosicion.Size = new System.Drawing.Size(125, 42);
            this.BtInsetarPosicion.TabIndex = 101;
            this.BtInsetarPosicion.Text = "Insetar en posicion";
            this.BtInsetarPosicion.UseVisualStyleBackColor = false;
            this.BtInsetarPosicion.Click += new System.EventHandler(this.BtInsetarPosicion_Click);
            // 
            // TxResultado
            // 
            this.TxResultado.Location = new System.Drawing.Point(29, 59);
            this.TxResultado.Multiline = true;
            this.TxResultado.Name = "TxResultado";
            this.TxResultado.Size = new System.Drawing.Size(339, 349);
            this.TxResultado.TabIndex = 100;
            // 
            // BtListaCDVaciar
            // 
            this.BtListaCDVaciar.BackColor = System.Drawing.Color.DarkBlue;
            this.BtListaCDVaciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtListaCDVaciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtListaCDVaciar.ForeColor = System.Drawing.Color.White;
            this.BtListaCDVaciar.Location = new System.Drawing.Point(673, 357);
            this.BtListaCDVaciar.Name = "BtListaCDVaciar";
            this.BtListaCDVaciar.Size = new System.Drawing.Size(74, 34);
            this.BtListaCDVaciar.TabIndex = 99;
            this.BtListaCDVaciar.Text = "Vaciar";
            this.BtListaCDVaciar.UseVisualStyleBackColor = false;
            this.BtListaCDVaciar.Click += new System.EventHandler(this.BtListaCDVaciar_Click);
            // 
            // frmListasCircularesDobles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Controls.Add(this.BtListaCDVaciar);
            this.Name = "frmListasCircularesDobles";
            this.Text = "frmListasCircularesDobles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Button BtListaCDVaciar;
    }
}