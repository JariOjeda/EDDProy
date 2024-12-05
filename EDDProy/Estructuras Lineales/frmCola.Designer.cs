namespace EDDemo.Estructuras_Lineales
{
    partial class frmCola
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
            this.BtDequeue = new System.Windows.Forms.Button();
            this.BtBuscar = new System.Windows.Forms.Button();
            this.BtQueue = new System.Windows.Forms.Button();
            this.TxResultado = new System.Windows.Forms.TextBox();
            this.BtColaVaciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Informacion";
            // 
            // TxInfo
            // 
            this.TxInfo.Location = new System.Drawing.Point(393, 350);
            this.TxInfo.Multiline = true;
            this.TxInfo.Name = "TxInfo";
            this.TxInfo.Size = new System.Drawing.Size(259, 55);
            this.TxInfo.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(393, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 49;
            this.label1.Text = "Escriba un dato";
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(160, 32);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(73, 25);
            this.Titulo.TabIndex = 48;
            this.Titulo.Text = "COLA";
            // 
            // TxInPut
            // 
            this.TxInPut.Location = new System.Drawing.Point(396, 96);
            this.TxInPut.Name = "TxInPut";
            this.TxInPut.Size = new System.Drawing.Size(326, 20);
            this.TxInPut.TabIndex = 47;
            // 
            // BtDequeue
            // 
            this.BtDequeue.BackColor = System.Drawing.Color.DarkBlue;
            this.BtDequeue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtDequeue.ForeColor = System.Drawing.Color.White;
            this.BtDequeue.Location = new System.Drawing.Point(513, 215);
            this.BtDequeue.Name = "BtDequeue";
            this.BtDequeue.Size = new System.Drawing.Size(75, 23);
            this.BtDequeue.TabIndex = 46;
            this.BtDequeue.Text = "Dequeue";
            this.BtDequeue.UseVisualStyleBackColor = false;
            this.BtDequeue.Click += new System.EventHandler(this.BtDequeue_Click);
            // 
            // BtBuscar
            // 
            this.BtBuscar.BackColor = System.Drawing.Color.DarkBlue;
            this.BtBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtBuscar.ForeColor = System.Drawing.Color.White;
            this.BtBuscar.Location = new System.Drawing.Point(513, 176);
            this.BtBuscar.Name = "BtBuscar";
            this.BtBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtBuscar.TabIndex = 45;
            this.BtBuscar.Text = "Buscar";
            this.BtBuscar.UseVisualStyleBackColor = false;
            this.BtBuscar.Click += new System.EventHandler(this.BtBuscar_Click);
            // 
            // BtQueue
            // 
            this.BtQueue.BackColor = System.Drawing.Color.DarkBlue;
            this.BtQueue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtQueue.ForeColor = System.Drawing.Color.White;
            this.BtQueue.Location = new System.Drawing.Point(513, 137);
            this.BtQueue.Name = "BtQueue";
            this.BtQueue.Size = new System.Drawing.Size(75, 23);
            this.BtQueue.TabIndex = 44;
            this.BtQueue.Text = "Queue";
            this.BtQueue.UseVisualStyleBackColor = false;
            this.BtQueue.Click += new System.EventHandler(this.BtQueue_Click);
            // 
            // TxResultado
            // 
            this.TxResultado.Location = new System.Drawing.Point(41, 60);
            this.TxResultado.Multiline = true;
            this.TxResultado.Name = "TxResultado";
            this.TxResultado.Size = new System.Drawing.Size(305, 357);
            this.TxResultado.TabIndex = 43;
            // 
            // BtColaVaciar
            // 
            this.BtColaVaciar.BackColor = System.Drawing.Color.DarkBlue;
            this.BtColaVaciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtColaVaciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtColaVaciar.ForeColor = System.Drawing.Color.White;
            this.BtColaVaciar.Location = new System.Drawing.Point(695, 361);
            this.BtColaVaciar.Name = "BtColaVaciar";
            this.BtColaVaciar.Size = new System.Drawing.Size(62, 30);
            this.BtColaVaciar.TabIndex = 42;
            this.BtColaVaciar.Text = "Vaciar";
            this.BtColaVaciar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtColaVaciar.UseVisualStyleBackColor = false;
            this.BtColaVaciar.Click += new System.EventHandler(this.BtColaVaciar_Click);
            // 
            // frmCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.TxInPut);
            this.Controls.Add(this.BtDequeue);
            this.Controls.Add(this.BtBuscar);
            this.Controls.Add(this.BtQueue);
            this.Controls.Add(this.TxResultado);
            this.Controls.Add(this.BtColaVaciar);
            this.Name = "frmCola";
            this.Text = "frmCola";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.TextBox TxInPut;
        private System.Windows.Forms.Button BtDequeue;
        private System.Windows.Forms.Button BtBuscar;
        private System.Windows.Forms.Button BtQueue;
        private System.Windows.Forms.TextBox TxResultado;
        private System.Windows.Forms.Button BtColaVaciar;
    }
}