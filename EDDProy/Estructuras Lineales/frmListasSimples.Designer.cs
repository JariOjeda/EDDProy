﻿namespace EDDemo.Estructuras_Lineales
{
    partial class frmListasSimples
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
            this.BtInsetarPosicion = new System.Windows.Forms.Button();
            this.BtInsetarFinal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.TxInPut = new System.Windows.Forms.TextBox();
            this.BtEliminarDato = new System.Windows.Forms.Button();
            this.BtBuscar = new System.Windows.Forms.Button();
            this.BtInsetarInicio = new System.Windows.Forms.Button();
            this.TxResultado = new System.Windows.Forms.TextBox();
            this.BtListaVaciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxPosicion
            // 
            this.TxPosicion.Location = new System.Drawing.Point(152, 231);
            this.TxPosicion.Name = "TxPosicion";
            this.TxPosicion.Size = new System.Drawing.Size(117, 20);
            this.TxPosicion.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 76;
            this.label3.Text = "Posicion";
            // 
            // BtInsetarPosicion
            // 
            this.BtInsetarPosicion.Location = new System.Drawing.Point(171, 257);
            this.BtInsetarPosicion.Name = "BtInsetarPosicion";
            this.BtInsetarPosicion.Size = new System.Drawing.Size(75, 41);
            this.BtInsetarPosicion.TabIndex = 75;
            this.BtInsetarPosicion.Text = "Insetar en posicion";
            this.BtInsetarPosicion.UseVisualStyleBackColor = true;
            this.BtInsetarPosicion.Click += new System.EventHandler(this.BtInsetarPosicion_Click);
            // 
            // BtInsetarFinal
            // 
            this.BtInsetarFinal.Location = new System.Drawing.Point(127, 169);
            this.BtInsetarFinal.Name = "BtInsetarFinal";
            this.BtInsetarFinal.Size = new System.Drawing.Size(75, 42);
            this.BtInsetarFinal.TabIndex = 74;
            this.BtInsetarFinal.Text = "Insetar Final";
            this.BtInsetarFinal.UseVisualStyleBackColor = true;
            this.BtInsetarFinal.Click += new System.EventHandler(this.BtInsetarFinal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "Informacion";
            // 
            // TxInfo
            // 
            this.TxInfo.Location = new System.Drawing.Point(46, 371);
            this.TxInfo.Multiline = true;
            this.TxInfo.Name = "TxInfo";
            this.TxInfo.Size = new System.Drawing.Size(326, 44);
            this.TxInfo.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "Escriba un dato";
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(502, 36);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(165, 25);
            this.Titulo.TabIndex = 70;
            this.Titulo.Text = "LISTA SIMPLE";
            // 
            // TxInPut
            // 
            this.TxInPut.Location = new System.Drawing.Point(46, 132);
            this.TxInPut.Name = "TxInPut";
            this.TxInPut.Size = new System.Drawing.Size(326, 20);
            this.TxInPut.TabIndex = 69;
            // 
            // BtEliminarDato
            // 
            this.BtEliminarDato.Location = new System.Drawing.Point(297, 169);
            this.BtEliminarDato.Name = "BtEliminarDato";
            this.BtEliminarDato.Size = new System.Drawing.Size(75, 42);
            this.BtEliminarDato.TabIndex = 68;
            this.BtEliminarDato.Text = "Eliminar un Dato";
            this.BtEliminarDato.UseVisualStyleBackColor = true;
            this.BtEliminarDato.Click += new System.EventHandler(this.BtEliminarDato_Click);
            // 
            // BtBuscar
            // 
            this.BtBuscar.Location = new System.Drawing.Point(208, 169);
            this.BtBuscar.Name = "BtBuscar";
            this.BtBuscar.Size = new System.Drawing.Size(75, 42);
            this.BtBuscar.TabIndex = 67;
            this.BtBuscar.Text = "Buscar";
            this.BtBuscar.UseVisualStyleBackColor = true;
            this.BtBuscar.Click += new System.EventHandler(this.BtBuscar_Click);
            // 
            // BtInsetarInicio
            // 
            this.BtInsetarInicio.Location = new System.Drawing.Point(46, 169);
            this.BtInsetarInicio.Name = "BtInsetarInicio";
            this.BtInsetarInicio.Size = new System.Drawing.Size(75, 42);
            this.BtInsetarInicio.TabIndex = 66;
            this.BtInsetarInicio.Text = "Insetar Inicio";
            this.BtInsetarInicio.UseVisualStyleBackColor = true;
            this.BtInsetarInicio.Click += new System.EventHandler(this.BtInsetarInicio_Click);
            // 
            // TxResultado
            // 
            this.TxResultado.Location = new System.Drawing.Point(392, 66);
            this.TxResultado.Multiline = true;
            this.TxResultado.Name = "TxResultado";
            this.TxResultado.Size = new System.Drawing.Size(385, 349);
            this.TxResultado.TabIndex = 65;
            // 
            // BtListaVaciar
            // 
            this.BtListaVaciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtListaVaciar.Location = new System.Drawing.Point(24, 36);
            this.BtListaVaciar.Name = "BtListaVaciar";
            this.BtListaVaciar.Size = new System.Drawing.Size(97, 48);
            this.BtListaVaciar.TabIndex = 64;
            this.BtListaVaciar.Text = "Vaciar";
            this.BtListaVaciar.UseVisualStyleBackColor = true;
            this.BtListaVaciar.Click += new System.EventHandler(this.BtListaVaciar_Click);
            // 
            // frmListasSimples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxPosicion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtInsetarPosicion);
            this.Controls.Add(this.BtInsetarFinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.TxInPut);
            this.Controls.Add(this.BtEliminarDato);
            this.Controls.Add(this.BtBuscar);
            this.Controls.Add(this.BtInsetarInicio);
            this.Controls.Add(this.TxResultado);
            this.Controls.Add(this.BtListaVaciar);
            this.Name = "frmListasSimples";
            this.Text = "frmListasSimples";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxPosicion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtInsetarPosicion;
        private System.Windows.Forms.Button BtInsetarFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.TextBox TxInPut;
        private System.Windows.Forms.Button BtEliminarDato;
        private System.Windows.Forms.Button BtBuscar;
        private System.Windows.Forms.Button BtInsetarInicio;
        private System.Windows.Forms.TextBox TxResultado;
        private System.Windows.Forms.Button BtListaVaciar;
    }
}