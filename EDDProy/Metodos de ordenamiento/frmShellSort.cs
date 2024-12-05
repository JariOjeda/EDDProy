using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using EDDemo.Estructuras_Lineales.Clases;
using EDDemo.Metodos_de_ordenamiento.Clases;

namespace EDDemo.Metodos_de_ordenamiento
{
    public partial class frmShellSort : Form
    {
        public frmShellSort()
        {
            InitializeComponent();
        }

        private void BtnGenerarLista_Click(object sender, EventArgs e)
        {
            int cantidad;
            if (int.TryParse(TxtNumeroElementos.Text, out cantidad) && cantidad > 0)
            {
                ListaSimple lista = new ListaSimple();
                Random random = new Random();

                for (int i = 0; i < cantidad; i++)
                {
                    int numero = random.Next(1, 100);
                    lista.InsertarFinal(numero.ToString());
                }

                // MOSTRAR LISTA
                TxtLista.Text = lista.ToString();
            }
            else
            {
                MessageBox.Show("Ingresa un número válido.");
            }
        }
        private ListaSimple CrearListaDesdeTextBox(string texto)
        {
            ListaSimple lista = new ListaSimple();

            // "->", "," Y ESPACIOS
            string[] valores = texto.Split(new string[] { "->", ",", " " }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string valor in valores)
            {
                string trimmedValue = valor.Trim();

                // VALIDAR EL VALOR ES UN NUMERO ENTERO
                if (trimmedValue.Equals("null", StringComparison.OrdinalIgnoreCase))
                {
                    continue; // Ignorar el texto "null"
                }

                if (int.TryParse(trimmedValue, out int _))
                {
                    lista.InsertarFinal(trimmedValue);
                }
                else
                {
                    if (!string.IsNullOrEmpty(trimmedValue))
                    {
                        MessageBox.Show($"El valor '{valor}' no es válido y será ignorado.",
                                        "Advertencia",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    }
                }
            }

            return lista;
        }

        private void BtnOrdenarLista_Click(object sender, EventArgs e)
        {
            // VERIFICAR QUE EXISTAN DATOS
            if (string.IsNullOrWhiteSpace(TxtLista.Text))
            {
                MessageBox.Show("Por favor ingresa una lista de valores separados por comas.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // CONVERTIR CONTENIDO TXT A LISTA SIMPLE
            ListaSimple lista = CrearListaDesdeTextBox(TxtLista.Text);

            if (lista.estaVacio())
            {
                MessageBox.Show("La lista está vacía o contiene elementos no válidos.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // INICIAR CRONOMETRO
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // LLAMADAS A RADIX PARA ORDENAR LISTA SIMPLE
            ShellSort.FuncionShellSort(lista);

            // DETENER  CRONOMETRO
            stopwatch.Stop();

            // MOSTRAR LISTA ORDENADA
            TxtListaOrdenada.Text = lista.ToString(); // IMPLEMENTACION DE TOSTRING PARA LISTA SIMPLE

            // TIEMPO
            txtTiempo.Text = $"{stopwatch.ElapsedTicks} ticks";
        }
    }

}
