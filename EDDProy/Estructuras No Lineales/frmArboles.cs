using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace EDDemo.Estructuras_No_Lineales
{
    public partial class frmArboles : Form
    {
        ArbolBusqueda miArbol;
        NodoBinario miRaiz;

        public frmArboles()
        {
            InitializeComponent();
            miArbol = new ArbolBusqueda();
            miRaiz = null;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDato.Text, out int valor))
            {
                bool insertado = miArbol.InsertarNodoRecursivo(valor);
                if (insertado)
                {
                    // OBTENER NODO RAIZ DEL ARBOL
                    miRaiz = miArbol.RegresaRaiz();
                    // LIMPIAR CADENA DONDE CONCATENAN LOS NODOS
                    miArbol.strArbol = "";
                    // LEER ARBOL Y MOSTRAR 
                    miArbol.MuestraArbolAcostado(1, miRaiz);
                    txtArbol.Text = miArbol.strArbol;
                    MessageBox.Show("Nodo insertado correctamente.");
                }
                else
                {
                    MessageBox.Show("El valor ya existe en el arbol.");
                }
            }
            else
            {
                MessageBox.Show("Ingresa un numero valido.");
            }

            txtDato.Text = "";

        }


        private void btnCrearArbol_Click(object sender, EventArgs e)
        {
            // LIMPIAR OBJETOS Y CLASES ANTERIORES
            miArbol = null;
            miRaiz = null;
            miArbol = new ArbolBusqueda();
            txtArbol.Text = "";
            txtDato.Text = "";

            miArbol.strArbol = "";

            Random rnd = new Random();

            for (int nNodos = 1; nNodos <= txtNodos.Value; nNodos++)
            {
                int Dato = rnd.Next(1, 100);
                // OBTENER NODO RAIZ
                miRaiz = miArbol.RegresaRaiz();

                // INSERTAR NODO CON DATO CAPTURADO
                miArbol.InsertaNodo(Dato, ref miRaiz);
            }

            // LEER ARBOL Y MOSTRARLO
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;

            txtDato.Text = "";
        }

        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            // RECORRIDO PREORDEN
            // OBTENER NODO RAIZ
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPreOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoPreOrden.Text = "";
            miArbol.PreOrden(miRaiz);

            lblRecorridoPreOrden.Text = miArbol.strRecorrido;


            // RECORRIDO INORDEN
            // OBTENER NODO RAIZ
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPostOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoInOrden.Text = "";
            miArbol.InOrden(miRaiz);
            lblRecorridoInOrden.Text = miArbol.strRecorrido;


            // RECORRIDO EN POSTORDEN
            // OBTENER NODO RAIZ
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPostOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoPostOrden.Text = "";
            miArbol.PostOrden(miRaiz);
            lblRecorridoPostOrden.Text = miArbol.strRecorrido;
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDato.Text, out int valor))
            {
                miRaiz = miArbol.RegresaRaiz();
                bool encontrado = miArbol.Busqueda(valor, miRaiz);
                if (encontrado)
                    MessageBox.Show($"El {valor} SI se encuentra en el arbol.");
                else
                    MessageBox.Show($"El {valor} NO se encuentra en el arbol.");
            }
            else
            {
                MessageBox.Show($"Ingresa un numero valido.");
            }

            txtDato.Text = "";
        }

        private void btnGrafica_Click(object sender, EventArgs e)
        {
            String graphVizString;
            String strOrientacion = "";

            miRaiz = miArbol.RegresaRaiz();
            if (miRaiz == null)
            {
                MessageBox.Show("El arbol esta vacio");
                return;
            }

            if (rbOrientacion2.Checked)
            {
                strOrientacion = "rankdir=\"LR\";";
            }
            StringBuilder b = new StringBuilder();
            //rankdir="LR";
            b.Append("digraph G { " + strOrientacion + " node [shape=\"circle\"]; " + Environment.NewLine);
            b.Append(miArbol.ToDot(miRaiz));
            b.Append("}");
            graphVizString = b.ToString();

            //graphVizString = @" digraph g{ label=""Graph""; labelloc=top;labeljust=left;}";
            //graphVizString = @"digraph Arbol{Raiz->60; 60->40. 60->90; 40->34; 40->50;}";
            Bitmap bm = FileDotEngine.Run(graphVizString);


            frmGrafica graf = new frmGrafica();
            graf.ActualizaGrafica(bm);
            graf.MdiParent = this.MdiParent;
            graf.Show();
        }

        private void btnEliminarPredecesor_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(txtDato.Text);
            miArbol.EliminarPredecesor(miArbol.RegresaRaiz(), valor);
            miArbol.strArbol = "";
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;
        }

        private void btnEliminarSucesor_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(txtDato.Text);
            miArbol.EliminarSucesor(miArbol.RegresaRaiz(), valor);
            miArbol.strArbol = "";
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;
        }

        private void btnEsCompleto_Click(object sender, EventArgs e)
        {
            bool esCompleto = miArbol.EsCompleto();
            MessageBox.Show(esCompleto ? "El arbol es completo." : "El arbol NO es completo");
        }

        private void btnEsLleno_Click(object sender, EventArgs e)
        {
            bool esLleno = miArbol.EsLleno();
            MessageBox.Show(esLleno ? "El arbol es lleno." : "El arbol NO es lleno.");
        }

        private void btnContarNodos_Click(object sender, EventArgs e)
        {
            int nodos = miArbol.ContarNodos(miRaiz);
            MessageBox.Show($"El arbol tiene {nodos} nodos.");
        }

        private void btnContarHojas_Click(object sender, EventArgs e)
        {
            int hojas = miArbol.ContarHojas(miRaiz);
            MessageBox.Show($"El arbol tiene {hojas} hojas.");
        }

        private void btnAltura_Click(object sender, EventArgs e)
        {
            int altura = miArbol.Altura(miRaiz);
            MessageBox.Show($"La altura del arbol es: {altura}");
        }

        private void btnRecorrerPorNiveles_Click(object sender, EventArgs e)
        {
            miArbol.RecorrerPorNiveles();
            lblRecorridoPorNiveles.Text = miArbol.strRecorrido;
        }

        private void btnPodar_Click(object sender, EventArgs e)
        {
            miArbol.PodarArbolCompleto();
            txtArbol.Text = "Arbol podado.";
            lblRecorridoPreOrden.Text = "";
            lblRecorridoInOrden.Text = "";
            lblRecorridoPostOrden.Text = "";
        }
    }
}
