using System;
using EDDemo.Estructuras_Lineales.Clases;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Metodos_de_ordenamiento.Clases;
using System.Diagnostics;

namespace EDDemo.Metodos_de_ordenamiento
{
    public partial class frmIntercalacion : Form
    {
        Intercalacion intercalacion = new Intercalacion();
        public frmIntercalacion()
        {
            InitializeComponent();
        }

        private HashSet<int> ArchivoNum1 = new HashSet<int>();
        private HashSet<int> ArchivoNum2 = new HashSet<int>();

        // GENERAR ARCHIVO
        private void GenerarArchivo(int NumElementos, int archivo)
        {
            HashSet<int> NumsGenerados = archivo == 1 ? ArchivoNum1 : ArchivoNum2;
            Random random = new Random();
            while (NumsGenerados.Count < NumElementos)
            {
                int NumeroRandom = random.Next(1, 1001);
                if (!ArchivoNum1.Contains(NumeroRandom) && !ArchivoNum2.Contains(NumeroRandom))
                {
                    NumsGenerados.Add(NumeroRandom);
                }
            }
        }

        private void BtnGenerarArchivo1_Click(object sender, EventArgs e)
        {
            TxtArchivo1.Clear();
            if (int.TryParse(TxtNumElementosArchivo1.Text, out int cantidadArchivo1))
            {
                if (cantidadArchivo1 > 0)
                {
                    ArchivoNum1.Clear();

                    GenerarArchivo(cantidadArchivo1, 1);

                    TxtArchivo1.Text = string.Join(", ", ArchivoNum1.OrderBy(n => n));
                }
                else
                {
                    MessageBox.Show("Introduce el numero de elementos del archivo");
                }
            }
            else
            {
                MessageBox.Show("Elemento invalido");
            }
        }

        private void BtnGenerarArchivo2_Click(object sender, EventArgs e)
        {
            TxtArchivo2.Clear();
            if (int.TryParse(TxtNumElementosArchivo2.Text, out int EkementosdArchivo2))
            {
                if (EkementosdArchivo2 > 0)
                {
                    ArchivoNum2.Clear();
                    GenerarArchivo(EkementosdArchivo2, 2);
                    TxtArchivo2.Text = string.Join(", ", ArchivoNum2.OrderBy(n => n));
                }
                else
                {
                    MessageBox.Show("Introduce el numero de elementos del archivo");
                }
            }
            else
            {
                MessageBox.Show("Elemento invalido");
            }
        }

        // CREAR LISTA
        private ListaSimple CrearLista(string texto)
        {
            ListaSimple lista = new ListaSimple();
            string[] valores = texto.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string valor in valores)
            {
                lista.InsertarFinal(valor.Trim());
            }

            return lista;
        }

        private void BtnIntercalarArchivos_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            ListaSimple lista1 = CrearLista(TxtArchivo1.Text);
            ListaSimple lista2 = CrearLista(TxtArchivo2.Text);
            ListaSimple listaIntercalada = intercalacion.FuncionIntercalacion(lista1, lista2);
            stopwatch.Stop();
            TxtTiempo.Text = $"{stopwatch.ElapsedTicks} ticks";
            (string intercaladosTexto, _) = listaIntercalada.Recorrer();
            TxtArchivoIntercalado.Text = intercaladosTexto;
        }
    }
}
