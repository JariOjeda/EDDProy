using EDDemo.Algoritmos_de_recursividad.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Algoritmos_de_recursividad
{
    public partial class FrmBusquedaBinaria : Form
    {
        BusquedaBinaria bbinaria = new BusquedaBinaria();
        private int[] arreglo;
        public FrmBusquedaBinaria()
        {
            InitializeComponent();
        }

        private void btGenerarArreglo_Click(object sender, EventArgs e)
        {
            int numElementos;
            if (int.TryParse(EscribirNumElementosBusquedaTxtBox.Text, out numElementos) && numElementos > 0)
            {
                // GENERA Y ORDENA EL ARREGLO
                arreglo = bbinaria.GenerarArregloAleatorio(numElementos);
                Array.Sort(arreglo);

                // MUESTRA EL ARREGLO ORDENADO
                ResultadoGenerarArregloTxtBox.Text = "Arreglo ordenado: \n" + string.Join(" ", arreglo);
                ResultadoGenerarArregloTxtBox.Visible = true;
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número entero positivo.");
            }
        }

        private void btBuscarEnArreglo_Click(object sender, EventArgs e)
        {
            // INICIA EL TEMP
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            if (arreglo == null || arreglo.Length == 0) // VALIDA QUE ESTE INICIALIZADO EL ARREGLO
            {
                MessageBox.Show("Por favor, genera un arreglo antes de realizar la búsqueda.");
                return;
            }
            int numeroBuscado;
            if (int.TryParse(PedirNumeroBusquedaTxtBox.Text, out numeroBuscado))
            {
                // LLAMA A LA FUNCION RECURSIVA PARA BUSCAR EL NUMERO
                List<int> indices = bbinaria.BuscarTodosIndices(arreglo, numeroBuscado, 0, arreglo.Length - 1);
                // MUESTRA RESULTADO
                if (indices.Count == 0)
                {
                    ResultadoIndicesTxtBox.Text = "Número no encontrado.";
                }
                else
                {
                    ResultadoIndicesTxtBox.Text = $"Número encontrado en los índices: \n" + string.Join("  ", indices);
                }

                ResultadoIndicesTxtBox.Visible = true;
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número entero válido.");
            }
            // DET TEMP
            stopwatch.Stop();

            // MUESTRA TIEMPO EN TICKS 
            LblTiempo.Text = $"Tiempo de búsqueda: {stopwatch.ElapsedTicks} ticks";
        }
    }
}
