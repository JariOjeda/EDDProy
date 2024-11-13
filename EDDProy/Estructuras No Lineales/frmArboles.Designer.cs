
namespace EDDemo.Estructuras_No_Lineales
{
    partial class frmArboles
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
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtArbol = new System.Windows.Forms.TextBox();
            this.lblDatos = new System.Windows.Forms.Label();
            this.btnCrearArbol = new System.Windows.Forms.Button();
            this.btnRecorrer = new System.Windows.Forms.Button();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.btnGrafica = new System.Windows.Forms.Button();
            this.lblPostOrden = new System.Windows.Forms.Label();
            this.lblInOrden = new System.Windows.Forms.Label();
            this.lblPreOrden = new System.Windows.Forms.Label();
            this.lblRecorridoPreOrden = new System.Windows.Forms.Label();
            this.lblRecorridoInOrden = new System.Windows.Forms.Label();
            this.lblRecorridoPostOrden = new System.Windows.Forms.Label();
            this.txtNodos = new System.Windows.Forms.NumericUpDown();
            this.rbOrientacion1 = new System.Windows.Forms.RadioButton();
            this.btnEliminarPredecesor = new System.Windows.Forms.Button();
            this.btnEliminarSucesor = new System.Windows.Forms.Button();
            this.btnEsCompleto = new System.Windows.Forms.Button();
            this.btnEsLleno = new System.Windows.Forms.Button();
            this.btnContarNodos = new System.Windows.Forms.Button();
            this.btnContarHojas = new System.Windows.Forms.Button();
            this.btnAltura = new System.Windows.Forms.Button();
            this.rbOrientacion2 = new System.Windows.Forms.RadioButton();
            this.btnRecorrerPorNiveles = new System.Windows.Forms.Button();
            this.lblRecorridoPorNiveles = new System.Windows.Forms.Label();
            this.btnPodar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtNodos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(42, 16);
            this.txtDato.Margin = new System.Windows.Forms.Padding(2);
            this.txtDato.Multiline = true;
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(52, 26);
            this.txtDato.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(104, 16);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(62, 24);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Insertar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtArbol
            // 
            this.txtArbol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArbol.Location = new System.Drawing.Point(-2, 305);
            this.txtArbol.Margin = new System.Windows.Forms.Padding(2);
            this.txtArbol.Multiline = true;
            this.txtArbol.Name = "txtArbol";
            this.txtArbol.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtArbol.Size = new System.Drawing.Size(571, 267);
            this.txtArbol.TabIndex = 2;
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Location = new System.Drawing.Point(6, 21);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(36, 13);
            this.lblDatos.TabIndex = 3;
            this.lblDatos.Text = "Dato :";
            // 
            // btnCrearArbol
            // 
            this.btnCrearArbol.Location = new System.Drawing.Point(104, 48);
            this.btnCrearArbol.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearArbol.Name = "btnCrearArbol";
            this.btnCrearArbol.Size = new System.Drawing.Size(62, 34);
            this.btnCrearArbol.TabIndex = 4;
            this.btnCrearArbol.Text = "Crear Arbol";
            this.btnCrearArbol.UseVisualStyleBackColor = true;
            this.btnCrearArbol.Click += new System.EventHandler(this.btnCrearArbol_Click);
            // 
            // btnRecorrer
            // 
            this.btnRecorrer.Location = new System.Drawing.Point(104, 86);
            this.btnRecorrer.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecorrer.Name = "btnRecorrer";
            this.btnRecorrer.Size = new System.Drawing.Size(62, 24);
            this.btnRecorrer.TabIndex = 5;
            this.btnRecorrer.Text = "Recorrer";
            this.btnRecorrer.UseVisualStyleBackColor = true;
            this.btnRecorrer.Click += new System.EventHandler(this.btnRecorrer_Click);
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Location = new System.Drawing.Point(104, 114);
            this.btnBusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(62, 24);
            this.btnBusqueda.TabIndex = 6;
            this.btnBusqueda.Text = "Buscar";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // btnGrafica
            // 
            this.btnGrafica.Location = new System.Drawing.Point(334, 148);
            this.btnGrafica.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrafica.Name = "btnGrafica";
            this.btnGrafica.Size = new System.Drawing.Size(62, 24);
            this.btnGrafica.TabIndex = 7;
            this.btnGrafica.Text = "Grafica";
            this.btnGrafica.UseVisualStyleBackColor = true;
            this.btnGrafica.Click += new System.EventHandler(this.btnGrafica_Click);
            // 
            // lblPostOrden
            // 
            this.lblPostOrden.AutoSize = true;
            this.lblPostOrden.Location = new System.Drawing.Point(336, 273);
            this.lblPostOrden.Name = "lblPostOrden";
            this.lblPostOrden.Size = new System.Drawing.Size(60, 13);
            this.lblPostOrden.TabIndex = 8;
            this.lblPostOrden.Text = "PostOrden:";
            // 
            // lblInOrden
            // 
            this.lblInOrden.AutoSize = true;
            this.lblInOrden.Location = new System.Drawing.Point(336, 247);
            this.lblInOrden.Name = "lblInOrden";
            this.lblInOrden.Size = new System.Drawing.Size(48, 13);
            this.lblInOrden.TabIndex = 9;
            this.lblInOrden.Text = "InOrden:";
            // 
            // lblPreOrden
            // 
            this.lblPreOrden.AutoSize = true;
            this.lblPreOrden.Location = new System.Drawing.Point(336, 221);
            this.lblPreOrden.Name = "lblPreOrden";
            this.lblPreOrden.Size = new System.Drawing.Size(55, 13);
            this.lblPreOrden.TabIndex = 10;
            this.lblPreOrden.Text = "PreOrden:";
            // 
            // lblRecorridoPreOrden
            // 
            this.lblRecorridoPreOrden.AutoSize = true;
            this.lblRecorridoPreOrden.Location = new System.Drawing.Point(409, 221);
            this.lblRecorridoPreOrden.Name = "lblRecorridoPreOrden";
            this.lblRecorridoPreOrden.Size = new System.Drawing.Size(55, 13);
            this.lblRecorridoPreOrden.TabIndex = 11;
            this.lblRecorridoPreOrden.Text = "PreOrden:";
            // 
            // lblRecorridoInOrden
            // 
            this.lblRecorridoInOrden.AutoSize = true;
            this.lblRecorridoInOrden.Location = new System.Drawing.Point(409, 247);
            this.lblRecorridoInOrden.Name = "lblRecorridoInOrden";
            this.lblRecorridoInOrden.Size = new System.Drawing.Size(48, 13);
            this.lblRecorridoInOrden.TabIndex = 12;
            this.lblRecorridoInOrden.Text = "InOrden:";
            // 
            // lblRecorridoPostOrden
            // 
            this.lblRecorridoPostOrden.AutoSize = true;
            this.lblRecorridoPostOrden.Location = new System.Drawing.Point(409, 273);
            this.lblRecorridoPostOrden.Name = "lblRecorridoPostOrden";
            this.lblRecorridoPostOrden.Size = new System.Drawing.Size(60, 13);
            this.lblRecorridoPostOrden.TabIndex = 13;
            this.lblRecorridoPostOrden.Text = "PostOrden:";
            // 
            // txtNodos
            // 
            this.txtNodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNodos.Location = new System.Drawing.Point(40, 54);
            this.txtNodos.Margin = new System.Windows.Forms.Padding(2);
            this.txtNodos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNodos.Name = "txtNodos";
            this.txtNodos.Size = new System.Drawing.Size(60, 24);
            this.txtNodos.TabIndex = 8;
            this.txtNodos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rbOrientacion1
            // 
            this.rbOrientacion1.AutoSize = true;
            this.rbOrientacion1.Location = new System.Drawing.Point(336, 183);
            this.rbOrientacion1.Margin = new System.Windows.Forms.Padding(2);
            this.rbOrientacion1.Name = "rbOrientacion1";
            this.rbOrientacion1.Size = new System.Drawing.Size(60, 17);
            this.rbOrientacion1.TabIndex = 16;
            this.rbOrientacion1.TabStop = true;
            this.rbOrientacion1.Text = "Vertical";
            this.rbOrientacion1.UseVisualStyleBackColor = true;
            // 
            // btnEliminarPredecesor
            // 
            this.btnEliminarPredecesor.Location = new System.Drawing.Point(429, 39);
            this.btnEliminarPredecesor.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarPredecesor.Name = "btnEliminarPredecesor";
            this.btnEliminarPredecesor.Size = new System.Drawing.Size(128, 24);
            this.btnEliminarPredecesor.TabIndex = 18;
            this.btnEliminarPredecesor.Text = "Eliminar Predecesor";
            this.btnEliminarPredecesor.UseVisualStyleBackColor = true;
            this.btnEliminarPredecesor.Click += new System.EventHandler(this.btnEliminarPredecesor_Click);
            // 
            // btnEliminarSucesor
            // 
            this.btnEliminarSucesor.Location = new System.Drawing.Point(429, 67);
            this.btnEliminarSucesor.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarSucesor.Name = "btnEliminarSucesor";
            this.btnEliminarSucesor.Size = new System.Drawing.Size(128, 24);
            this.btnEliminarSucesor.TabIndex = 19;
            this.btnEliminarSucesor.Text = "Eliminar Sucesor";
            this.btnEliminarSucesor.UseVisualStyleBackColor = true;
            this.btnEliminarSucesor.Click += new System.EventHandler(this.btnEliminarSucesor_Click);
            // 
            // btnEsCompleto
            // 
            this.btnEsCompleto.Location = new System.Drawing.Point(56, 247);
            this.btnEsCompleto.Margin = new System.Windows.Forms.Padding(2);
            this.btnEsCompleto.Name = "btnEsCompleto";
            this.btnEsCompleto.Size = new System.Drawing.Size(104, 24);
            this.btnEsCompleto.TabIndex = 20;
            this.btnEsCompleto.Text = "¿Es Completo?";
            this.btnEsCompleto.UseVisualStyleBackColor = true;
            this.btnEsCompleto.Click += new System.EventHandler(this.btnEsCompleto_Click);
            // 
            // btnEsLleno
            // 
            this.btnEsLleno.Location = new System.Drawing.Point(187, 247);
            this.btnEsLleno.Margin = new System.Windows.Forms.Padding(2);
            this.btnEsLleno.Name = "btnEsLleno";
            this.btnEsLleno.Size = new System.Drawing.Size(99, 24);
            this.btnEsLleno.TabIndex = 21;
            this.btnEsLleno.Text = "¿Es Lleno?";
            this.btnEsLleno.UseVisualStyleBackColor = true;
            this.btnEsLleno.Click += new System.EventHandler(this.btnEsLleno_Click);
            // 
            // btnContarNodos
            // 
            this.btnContarNodos.Location = new System.Drawing.Point(246, 48);
            this.btnContarNodos.Margin = new System.Windows.Forms.Padding(2);
            this.btnContarNodos.Name = "btnContarNodos";
            this.btnContarNodos.Size = new System.Drawing.Size(98, 24);
            this.btnContarNodos.TabIndex = 22;
            this.btnContarNodos.Text = "Contar Nodos";
            this.btnContarNodos.UseVisualStyleBackColor = true;
            this.btnContarNodos.Click += new System.EventHandler(this.btnContarNodos_Click);
            // 
            // btnContarHojas
            // 
            this.btnContarHojas.Location = new System.Drawing.Point(246, 16);
            this.btnContarHojas.Margin = new System.Windows.Forms.Padding(2);
            this.btnContarHojas.Name = "btnContarHojas";
            this.btnContarHojas.Size = new System.Drawing.Size(98, 24);
            this.btnContarHojas.TabIndex = 23;
            this.btnContarHojas.Text = "Contar Hojas";
            this.btnContarHojas.UseVisualStyleBackColor = true;
            this.btnContarHojas.Click += new System.EventHandler(this.btnContarHojas_Click);
            // 
            // btnAltura
            // 
            this.btnAltura.Location = new System.Drawing.Point(246, 86);
            this.btnAltura.Margin = new System.Windows.Forms.Padding(2);
            this.btnAltura.Name = "btnAltura";
            this.btnAltura.Size = new System.Drawing.Size(98, 24);
            this.btnAltura.TabIndex = 24;
            this.btnAltura.Text = "Altura";
            this.btnAltura.UseVisualStyleBackColor = true;
            this.btnAltura.Click += new System.EventHandler(this.btnAltura_Click);
            // 
            // rbOrientacion2
            // 
            this.rbOrientacion2.AutoSize = true;
            this.rbOrientacion2.Location = new System.Drawing.Point(412, 183);
            this.rbOrientacion2.Margin = new System.Windows.Forms.Padding(2);
            this.rbOrientacion2.Name = "rbOrientacion2";
            this.rbOrientacion2.Size = new System.Drawing.Size(72, 17);
            this.rbOrientacion2.TabIndex = 25;
            this.rbOrientacion2.TabStop = true;
            this.rbOrientacion2.Text = "Horizontal";
            this.rbOrientacion2.UseVisualStyleBackColor = true;
            // 
            // btnRecorrerPorNiveles
            // 
            this.btnRecorrerPorNiveles.Location = new System.Drawing.Point(56, 204);
            this.btnRecorrerPorNiveles.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecorrerPorNiveles.Name = "btnRecorrerPorNiveles";
            this.btnRecorrerPorNiveles.Size = new System.Drawing.Size(123, 24);
            this.btnRecorrerPorNiveles.TabIndex = 26;
            this.btnRecorrerPorNiveles.Text = "Recorrer por Niveles";
            this.btnRecorrerPorNiveles.UseVisualStyleBackColor = true;
            this.btnRecorrerPorNiveles.Click += new System.EventHandler(this.btnRecorrerPorNiveles_Click);
            // 
            // lblRecorridoPorNiveles
            // 
            this.lblRecorridoPorNiveles.AutoSize = true;
            this.lblRecorridoPorNiveles.Location = new System.Drawing.Point(184, 210);
            this.lblRecorridoPorNiveles.Name = "lblRecorridoPorNiveles";
            this.lblRecorridoPorNiveles.Size = new System.Drawing.Size(53, 13);
            this.lblRecorridoPorNiveles.TabIndex = 27;
            this.lblRecorridoPorNiveles.Text = "Recorrido";
            // 
            // btnPodar
            // 
            this.btnPodar.Location = new System.Drawing.Point(467, 11);
            this.btnPodar.Margin = new System.Windows.Forms.Padding(2);
            this.btnPodar.Name = "btnPodar";
            this.btnPodar.Size = new System.Drawing.Size(90, 24);
            this.btnPodar.TabIndex = 28;
            this.btnPodar.Text = "Podar Arbol";
            this.btnPodar.UseVisualStyleBackColor = true;
            this.btnPodar.Click += new System.EventHandler(this.btnPodar_Click);
            // 
            // frmArboles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 570);
            this.Controls.Add(this.btnPodar);
            this.Controls.Add(this.lblRecorridoPorNiveles);
            this.Controls.Add(this.btnRecorrerPorNiveles);
            this.Controls.Add(this.rbOrientacion2);
            this.Controls.Add(this.btnAltura);
            this.Controls.Add(this.btnContarHojas);
            this.Controls.Add(this.btnContarNodos);
            this.Controls.Add(this.btnEsLleno);
            this.Controls.Add(this.btnEsCompleto);
            this.Controls.Add(this.btnEliminarSucesor);
            this.Controls.Add(this.btnEliminarPredecesor);
            this.Controls.Add(this.rbOrientacion1);
            this.Controls.Add(this.txtNodos);
            this.Controls.Add(this.lblRecorridoPostOrden);
            this.Controls.Add(this.lblRecorridoInOrden);
            this.Controls.Add(this.lblRecorridoPreOrden);
            this.Controls.Add(this.lblPreOrden);
            this.Controls.Add(this.lblInOrden);
            this.Controls.Add(this.lblPostOrden);
            this.Controls.Add(this.btnGrafica);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.btnRecorrer);
            this.Controls.Add(this.btnCrearArbol);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.txtArbol);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtDato);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmArboles";
            this.Text = "frmArboles";
            ((System.ComponentModel.ISupportInitialize)(this.txtNodos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtArbol;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Button btnCrearArbol;
        private System.Windows.Forms.Button btnRecorrer;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.Button btnGrafica;
        private System.Windows.Forms.Label lblPostOrden;
        private System.Windows.Forms.Label lblInOrden;
        private System.Windows.Forms.Label lblPreOrden;
        private System.Windows.Forms.Label lblRecorridoPreOrden;
        private System.Windows.Forms.Label lblRecorridoInOrden;
        private System.Windows.Forms.Label lblRecorridoPostOrden;
        private System.Windows.Forms.NumericUpDown txtNodos;
        private System.Windows.Forms.RadioButton rbOrientacion1;
        private System.Windows.Forms.Button btnEliminarPredecesor;
        private System.Windows.Forms.Button btnEliminarSucesor;
        private System.Windows.Forms.Button btnEsCompleto;
        private System.Windows.Forms.Button btnEsLleno;
        private System.Windows.Forms.Button btnContarNodos;
        private System.Windows.Forms.Button btnContarHojas;
        private System.Windows.Forms.Button btnAltura;
        private System.Windows.Forms.RadioButton rbOrientacion2;
        private System.Windows.Forms.Button btnRecorrerPorNiveles;
        private System.Windows.Forms.Label lblRecorridoPorNiveles;
        private System.Windows.Forms.Button btnPodar;
    }
}