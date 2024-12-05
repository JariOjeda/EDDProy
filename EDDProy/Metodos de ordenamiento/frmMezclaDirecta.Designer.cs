namespace EDDemo.Metodos_de_ordenamiento
{
    partial class frmMezclaDirecta
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.BtnOrdenarLista = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtListaOrdenada = new System.Windows.Forms.TextBox();
            this.BtnGenerarLista = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtLista = new System.Windows.Forms.TextBox();
            this.txtCantidad1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 45);
            this.label1.TabIndex = 77;
            this.label1.Text = "MEZCLA DIRECTA";
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(443, 378);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.ReadOnly = true;
            this.txtTiempo.Size = new System.Drawing.Size(78, 20);
            this.txtTiempo.TabIndex = 76;
            // 
            // BtnOrdenarLista
            // 
            this.BtnOrdenarLista.BackColor = System.Drawing.Color.DarkBlue;
            this.BtnOrdenarLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOrdenarLista.ForeColor = System.Drawing.Color.White;
            this.BtnOrdenarLista.Location = new System.Drawing.Point(527, 104);
            this.BtnOrdenarLista.Name = "BtnOrdenarLista";
            this.BtnOrdenarLista.Size = new System.Drawing.Size(123, 42);
            this.BtnOrdenarLista.TabIndex = 75;
            this.BtnOrdenarLista.Text = "Ordenar";
            this.BtnOrdenarLista.UseVisualStyleBackColor = false;
            this.BtnOrdenarLista.Click += new System.EventHandler(this.BtnOrdenarLista_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(533, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 24);
            this.label6.TabIndex = 74;
            this.label6.Text = "Lista ordenada";
            // 
            // TxtListaOrdenada
            // 
            this.TxtListaOrdenada.Location = new System.Drawing.Point(443, 187);
            this.TxtListaOrdenada.Multiline = true;
            this.TxtListaOrdenada.Name = "TxtListaOrdenada";
            this.TxtListaOrdenada.Size = new System.Drawing.Size(315, 185);
            this.TxtListaOrdenada.TabIndex = 73;
            // 
            // BtnGenerarLista
            // 
            this.BtnGenerarLista.BackColor = System.Drawing.Color.DarkBlue;
            this.BtnGenerarLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGenerarLista.ForeColor = System.Drawing.Color.White;
            this.BtnGenerarLista.Location = new System.Drawing.Point(124, 152);
            this.BtnGenerarLista.Name = "BtnGenerarLista";
            this.BtnGenerarLista.Size = new System.Drawing.Size(123, 42);
            this.BtnGenerarLista.TabIndex = 72;
            this.BtnGenerarLista.Text = "Generar";
            this.BtnGenerarLista.UseVisualStyleBackColor = false;
            this.BtnGenerarLista.Click += new System.EventHandler(this.BtnGenerarLista_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "Numero de elementos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(162, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 24);
            this.label2.TabIndex = 70;
            this.label2.Text = "Lista";
            // 
            // TxtLista
            // 
            this.TxtLista.Location = new System.Drawing.Point(63, 261);
            this.TxtLista.Multiline = true;
            this.TxtLista.Name = "TxtLista";
            this.TxtLista.Size = new System.Drawing.Size(254, 158);
            this.TxtLista.TabIndex = 69;
            // 
            // txtCantidad1
            // 
            this.txtCantidad1.Location = new System.Drawing.Point(63, 126);
            this.txtCantidad1.Name = "txtCantidad1";
            this.txtCantidad1.Size = new System.Drawing.Size(254, 20);
            this.txtCantidad1.TabIndex = 68;
            // 
            // frmMezclaDirecta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.BtnOrdenarLista);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtListaOrdenada);
            this.Controls.Add(this.BtnGenerarLista);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtLista);
            this.Controls.Add(this.txtCantidad1);
            this.Name = "frmMezclaDirecta";
            this.Text = "frmMezclaDirecta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.Button BtnOrdenarLista;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtListaOrdenada;
        private System.Windows.Forms.Button BtnGenerarLista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtLista;
        private System.Windows.Forms.TextBox txtCantidad1;
    }
}