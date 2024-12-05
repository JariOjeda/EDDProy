namespace EDDemo.Algoritmos_de_recursividad
{
    partial class frmTorreHanoi
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
            this.ResultadoHanoiTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btEjecutarHanoi = new System.Windows.Forms.Button();
            this.labelPedirDiscos = new System.Windows.Forms.Label();
            this.LeerDiscosTxtBox = new System.Windows.Forms.TextBox();
            this.DescripcionHanoi = new System.Windows.Forms.Label();
            this.TituloHanoi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ResultadoHanoiTxtBox
            // 
            this.ResultadoHanoiTxtBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultadoHanoiTxtBox.Location = new System.Drawing.Point(39, 300);
            this.ResultadoHanoiTxtBox.Multiline = true;
            this.ResultadoHanoiTxtBox.Name = "ResultadoHanoiTxtBox";
            this.ResultadoHanoiTxtBox.Size = new System.Drawing.Size(706, 75);
            this.ResultadoHanoiTxtBox.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(360, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 21);
            this.label6.TabIndex = 44;
            // 
            // btEjecutarHanoi
            // 
            this.btEjecutarHanoi.BackColor = System.Drawing.Color.DarkBlue;
            this.btEjecutarHanoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEjecutarHanoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEjecutarHanoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEjecutarHanoi.ForeColor = System.Drawing.Color.White;
            this.btEjecutarHanoi.Location = new System.Drawing.Point(350, 236);
            this.btEjecutarHanoi.Name = "btEjecutarHanoi";
            this.btEjecutarHanoi.Size = new System.Drawing.Size(75, 34);
            this.btEjecutarHanoi.TabIndex = 43;
            this.btEjecutarHanoi.Text = "Ejecutar";
            this.btEjecutarHanoi.UseVisualStyleBackColor = false;
            this.btEjecutarHanoi.Click += new System.EventHandler(this.btEjecutarHanoi_Click);
            // 
            // labelPedirDiscos
            // 
            this.labelPedirDiscos.AutoSize = true;
            this.labelPedirDiscos.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPedirDiscos.Location = new System.Drawing.Point(18, 163);
            this.labelPedirDiscos.Name = "labelPedirDiscos";
            this.labelPedirDiscos.Size = new System.Drawing.Size(203, 21);
            this.labelPedirDiscos.TabIndex = 42;
            this.labelPedirDiscos.Text = "Dame el numero de discos";
            // 
            // LeerDiscosTxtBox
            // 
            this.LeerDiscosTxtBox.Location = new System.Drawing.Point(22, 196);
            this.LeerDiscosTxtBox.Name = "LeerDiscosTxtBox";
            this.LeerDiscosTxtBox.Size = new System.Drawing.Size(199, 20);
            this.LeerDiscosTxtBox.TabIndex = 41;
            // 
            // DescripcionHanoi
            // 
            this.DescripcionHanoi.AutoSize = true;
            this.DescripcionHanoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionHanoi.Location = new System.Drawing.Point(18, 54);
            this.DescripcionHanoi.Name = "DescripcionHanoi";
            this.DescripcionHanoi.Size = new System.Drawing.Size(606, 21);
            this.DescripcionHanoi.TabIndex = 40;
            this.DescripcionHanoi.Text = "Se resulve el problemas de las torres de hanoi en base  al numero de discos que l" +
    "e des";
            // 
            // TituloHanoi
            // 
            this.TituloHanoi.AutoSize = true;
            this.TituloHanoi.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloHanoi.ForeColor = System.Drawing.Color.DarkBlue;
            this.TituloHanoi.Location = new System.Drawing.Point(12, 9);
            this.TituloHanoi.Name = "TituloHanoi";
            this.TituloHanoi.Size = new System.Drawing.Size(310, 45);
            this.TituloHanoi.TabIndex = 39;
            this.TituloHanoi.Text = "Las torres de Hanoi";
            // 
            // frmTorreHanoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResultadoHanoiTxtBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btEjecutarHanoi);
            this.Controls.Add(this.labelPedirDiscos);
            this.Controls.Add(this.LeerDiscosTxtBox);
            this.Controls.Add(this.DescripcionHanoi);
            this.Controls.Add(this.TituloHanoi);
            this.Name = "frmTorreHanoi";
            this.Text = "frmTorreHanoi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ResultadoHanoiTxtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btEjecutarHanoi;
        private System.Windows.Forms.Label labelPedirDiscos;
        private System.Windows.Forms.TextBox LeerDiscosTxtBox;
        private System.Windows.Forms.Label DescripcionHanoi;
        private System.Windows.Forms.Label TituloHanoi;
    }
}