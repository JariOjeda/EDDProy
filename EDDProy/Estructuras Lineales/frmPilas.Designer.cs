
namespace EDDemo
{
    partial class frmPilas
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
            this.label2 = new System.Windows.Forms.Label();
            this.TxInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.TxInPut = new System.Windows.Forms.TextBox();
            this.BtEliminar = new System.Windows.Forms.Button();
            this.BtBuscar = new System.Windows.Forms.Button();
            this.BtAñadir = new System.Windows.Forms.Button();
            this.TxResultado = new System.Windows.Forms.TextBox();
            this.BtPilaVaciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Informacion";
            // 
            // TxInfo
            // 
            this.TxInfo.Location = new System.Drawing.Point(407, 418);
            this.TxInfo.Multiline = true;
            this.TxInfo.Name = "TxInfo";
            this.TxInfo.Size = new System.Drawing.Size(292, 62);
            this.TxInfo.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(554, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Escriba un dato";
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(175, 55);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(61, 25);
            this.Titulo.TabIndex = 37;
            this.Titulo.Text = "PILA";
            // 
            // TxInPut
            // 
            this.TxInPut.Location = new System.Drawing.Point(429, 170);
            this.TxInPut.Name = "TxInPut";
            this.TxInPut.Size = new System.Drawing.Size(326, 20);
            this.TxInPut.TabIndex = 36;
            // 
            // BtEliminar
            // 
            this.BtEliminar.BackColor = System.Drawing.Color.DarkBlue;
            this.BtEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEliminar.ForeColor = System.Drawing.Color.White;
            this.BtEliminar.Location = new System.Drawing.Point(544, 252);
            this.BtEliminar.Name = "BtEliminar";
            this.BtEliminar.Size = new System.Drawing.Size(91, 38);
            this.BtEliminar.TabIndex = 35;
            this.BtEliminar.Text = "Pop";
            this.BtEliminar.UseVisualStyleBackColor = false;
            this.BtEliminar.Click += new System.EventHandler(this.BtEliminar_Click);
            // 
            // BtBuscar
            // 
            this.BtBuscar.BackColor = System.Drawing.Color.DarkBlue;
            this.BtBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtBuscar.ForeColor = System.Drawing.Color.White;
            this.BtBuscar.Location = new System.Drawing.Point(544, 306);
            this.BtBuscar.Name = "BtBuscar";
            this.BtBuscar.Size = new System.Drawing.Size(91, 38);
            this.BtBuscar.TabIndex = 34;
            this.BtBuscar.Text = "Buscar";
            this.BtBuscar.UseVisualStyleBackColor = false;
            this.BtBuscar.Click += new System.EventHandler(this.BtBuscar_Click);
            // 
            // BtAñadir
            // 
            this.BtAñadir.BackColor = System.Drawing.Color.DarkBlue;
            this.BtAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtAñadir.ForeColor = System.Drawing.Color.White;
            this.BtAñadir.Location = new System.Drawing.Point(544, 196);
            this.BtAñadir.Name = "BtAñadir";
            this.BtAñadir.Size = new System.Drawing.Size(91, 38);
            this.BtAñadir.TabIndex = 33;
            this.BtAñadir.Text = "Push";
            this.BtAñadir.UseVisualStyleBackColor = false;
            this.BtAñadir.Click += new System.EventHandler(this.BtAñadir_Click);
            // 
            // TxResultado
            // 
            this.TxResultado.Location = new System.Drawing.Point(33, 100);
            this.TxResultado.Multiline = true;
            this.TxResultado.Name = "TxResultado";
            this.TxResultado.Size = new System.Drawing.Size(345, 380);
            this.TxResultado.TabIndex = 32;
            // 
            // BtPilaVaciar
            // 
            this.BtPilaVaciar.BackColor = System.Drawing.Color.DarkBlue;
            this.BtPilaVaciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtPilaVaciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtPilaVaciar.ForeColor = System.Drawing.Color.White;
            this.BtPilaVaciar.Location = new System.Drawing.Point(724, 432);
            this.BtPilaVaciar.Name = "BtPilaVaciar";
            this.BtPilaVaciar.Size = new System.Drawing.Size(70, 36);
            this.BtPilaVaciar.TabIndex = 31;
            this.BtPilaVaciar.Text = "Vaciar";
            this.BtPilaVaciar.UseVisualStyleBackColor = false;
            this.BtPilaVaciar.Click += new System.EventHandler(this.BtPilaVaciar_Click);
            // 
            // frmPilas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 527);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.TxInPut);
            this.Controls.Add(this.BtEliminar);
            this.Controls.Add(this.BtBuscar);
            this.Controls.Add(this.BtAñadir);
            this.Controls.Add(this.TxResultado);
            this.Controls.Add(this.BtPilaVaciar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPilas";
            this.Text = "frmPilas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.TextBox TxInPut;
        private System.Windows.Forms.Button BtEliminar;
        private System.Windows.Forms.Button BtBuscar;
        private System.Windows.Forms.Button BtAñadir;
        private System.Windows.Forms.TextBox TxResultado;
        private System.Windows.Forms.Button BtPilaVaciar;
    }
}