using System;
using EDDemo.Estructuras_Lineales.Clases;
using EDDemo.Metodos_de_ordenamiento.Clases;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Metodos_de_ordenamiento
{
    public partial class frmMezclaDirecta : Form
    {
        ListaSimple lista = new ListaSimple();
        public frmMezclaDirecta()
        {
            InitializeComponent();
        }

        private void BtnGenerarLista_Click(object sender, EventArgs e)
        {
            int cantidad;
            if (int.TryParse(txtCantidad1.Text, out cantidad) && cantidad > 0)
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

                TxtLista.Text = listaTexto;
            }
            else
            {
                MessageBox.Show("Ingresa un número");
            }
        }

        private void BtnOrdenarLista_Click(object sender, EventArgs e)
        {
            string[] numerosTexto = TxtLista.Text.Split(new string[] { ", " }, StringSplitOptions.None);

            // INSERTAR NUMEROS EN LISTA ENLAZADA
            foreach (var numero in numerosTexto)
            {
                lista.InsertarFinal(numero);  // INSERTAR AL FINAL EN LA LISTA
            }

            // CRONOMETRO PARA MEDIR TIEMPO
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // LLAMADA AL ALGORITMO MEZLCA DIRECTA PARA ORDENAR LISTA
            lista = MezclaDirecta.MezclaDire(lista);

            stopwatch.Stop();

            // MOSTRAR LISTA ORDENADA
            TxtListaOrdenada.Text = lista.ToString();  // USAMOS TOSTRING PARA MOSTRAR NUMEROS ORDENADOS

            // Tiempo MOSTRAR TIEMPO DE EJECUCCION 
            txtTiempo.Text = $"{stopwatch.ElapsedTicks} ticks";
        }
    }
}
