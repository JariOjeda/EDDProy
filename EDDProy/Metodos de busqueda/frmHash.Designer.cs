namespace EDDemo.Metodos_de_busqueda
{
    partial class frmHash
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
            this.LblTiempo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.TxtResultado = new System.Windows.Forms.TextBox();
            this.TxtClaveABuscar = new System.Windows.Forms.TextBox();
            this.TxtClaves = new System.Windows.Forms.TextBox();
            this.TxtProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBuscarClave = new System.Windows.Forms.Button();
            this.BtnGenerarClave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblTiempo
            // 
            this.LblTiempo.AutoSize = true;
            this.LblTiempo.Location = new System.Drawing.Point(224, 428);
            this.LblTiempo.Name = "LblTiempo";
            this.LblTiempo.Size = new System.Drawing.Size(42, 13);
            this.LblTiempo.TabIndex = 31;
            this.LblTiempo.Text = "Tiempo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 45);
            this.label3.TabIndex = 30;
            this.label3.Text = "HASH";
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.DarkBlue;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.Location = new System.Drawing.Point(213, 111);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(96, 33);
            this.BtnLimpiar.TabIndex = 29;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // TxtResultado
            // 
            this.TxtResultado.Location = new System.Drawing.Point(413, 150);
            this.TxtResultado.Multiline = true;
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.Size = new System.Drawing.Size(360, 264);
            this.TxtResultado.TabIndex = 28;
            // 
            // TxtClaveABuscar
            // 
            this.TxtClaveABuscar.Location = new System.Drawing.Point(507, 85);
            this.TxtClaveABuscar.Name = "TxtClaveABuscar";
            this.TxtClaveABuscar.Size = new System.Drawing.Size(201, 20);
            this.TxtClaveABuscar.TabIndex = 27;
            // 
            // TxtClaves
            // 
            this.TxtClaves.Location = new System.Drawing.Point(20, 150);
            this.TxtClaves.Multiline = true;
            this.TxtClaves.Name = "TxtClaves";
            this.TxtClaves.Size = new System.Drawing.Size(360, 264);
            this.TxtClaves.TabIndex = 26;
            // 
            // TxtProducto
            // 
            this.TxtProducto.Location = new System.Drawing.Point(108, 85);
            this.TxtProducto.Name = "TxtProducto";
            this.TxtProducto.Size = new System.Drawing.Size(201, 20);
            this.TxtProducto.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(598, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Clave";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 33;
            // 
            // BtnBuscarClave
            // 
            this.BtnBuscarClave.BackColor = System.Drawing.Color.DarkBlue;
            this.BtnBuscarClave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarClave.ForeColor = System.Drawing.Color.White;
            this.BtnBuscarClave.Location = new System.Drawing.Point(563, 111);
            this.BtnBuscarClave.Name = "BtnBuscarClave";
            this.BtnBuscarClave.Size = new System.Drawing.Size(99, 33);
            this.BtnBuscarClave.TabIndex = 22;
            this.BtnBuscarClave.Text = "Buscar";
            this.BtnBuscarClave.UseVisualStyleBackColor = false;
            this.BtnBuscarClave.Click += new System.EventHandler(this.BtnBuscarClave_Click);
            // 
            // BtnGenerarClave
            // 
            this.BtnGenerarClave.BackColor = System.Drawing.Color.DarkBlue;
            this.BtnGenerarClave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGenerarClave.ForeColor = System.Drawing.Color.White;
            this.BtnGenerarClave.Location = new System.Drawing.Point(108, 111);
            this.BtnGenerarClave.Name = "BtnGenerarClave";
            this.BtnGenerarClave.Size = new System.Drawing.Size(99, 33);
            this.BtnGenerarClave.TabIndex = 21;
            this.BtnGenerarClave.Text = "Generar Clave";
            this.BtnGenerarClave.UseVisualStyleBackColor = false;
            this.BtnGenerarClave.Click += new System.EventHandler(this.BtnGenerarClave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(180, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Producto";
            // 
            // frmHash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblTiempo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.TxtResultado);
            this.Controls.Add(this.TxtClaveABuscar);
            this.Controls.Add(this.TxtClaves);
            this.Controls.Add(this.TxtProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnBuscarClave);
            this.Controls.Add(this.BtnGenerarClave);
            this.Name = "frmHash";
            this.Text = "frmHash";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTiempo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.TextBox TxtResultado;
        private System.Windows.Forms.TextBox TxtClaveABuscar;
        private System.Windows.Forms.TextBox TxtClaves;
        private System.Windows.Forms.TextBox TxtProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBuscarClave;
        private System.Windows.Forms.Button BtnGenerarClave;
        private System.Windows.Forms.Label label4;
    }
}