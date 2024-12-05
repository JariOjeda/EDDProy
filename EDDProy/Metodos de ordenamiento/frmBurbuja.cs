using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Estructuras_Lineales.Clases;
using System.Diagnostics;
using EDDemo.Metodos_de_ordenamiento.Clases;

namespace EDDemo.Metodos_de_ordenamiento
{
    public partial class frmBurbuja : Form
    {
        ListaSimple lista = new ListaSimple();
        public frmBurbuja()
        {
            InitializeComponent();
        }

        private void ActualizarLista()
        {
            var (recorrido, _) = lista.Recorrer();
            txtLista.Text = recorrido;  // MOSTRAR CONTENIDO LISTA 
        }
        private void btnGenerarLista_Click(object sender, EventArgs e)
        {
            int cantidad;
            if (int.TryParse(txtInPut.Text, out cantidad) && cantidad > 0)
            {
                Random random = new Random();
                string listaTexto = "";

                for (int i = 0; i < cantidad; i++)
                {
                    int numero = random.Next(1, 100);

                    if (i > 0)
                    {
                        listaTexto += ", ";
                    }

                    listaTexto += numero.ToString();
                }

                txtLista.Text = listaTexto;
            }
            else
            {
                MessageBox.Show("Ingresa un número");
            }
        }

        private void btnOrdenarLista_Click(object sender, EventArgs e)
        {
            // CONVERTIR LISTA DE TEXTO EN LISTA VINCULADA
            string[] numerosTexto = txtLista.Text.Split(new string[] { ", " }, StringSplitOptions.None);


            // INSERTA NUMEROS EN LA LISTA
            foreach (var numero in numerosTexto)
            {
                lista.InsertarFinal(numero); // SE HACE USO DEL METODO INSERTAR AL FINAL PARA AGG NODOS
            }

            // CRONOMETRO PARA TIEMPO DE EJECUCION
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // LLAMADA FUNCION BURBUJA
            Burbuja.OrdenarBurbuja(lista);

            stopwatch.Stop();

            // MOSTRAR RESULTADOS
            txtListaOrdenada.Text = lista.ToString(); // LLAMADA AL METODO TOSTRING DE LA CLASE LISTA SIMPLE

            txtTiempo.Text = $"{stopwatch.ElapsedTicks} ticks";
        }
    }
}
