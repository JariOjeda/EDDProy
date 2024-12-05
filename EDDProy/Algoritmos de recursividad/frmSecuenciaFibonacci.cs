using EDDemo.Algoritmos_de_recursividad.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Algoritmos_de_recursividad
{
    public partial class frmSecuenciaFibonacci : Form
    {
        Fibonacci fibonacci = new Fibonacci();
        public frmSecuenciaFibonacci()
        {
            InitializeComponent();
        }

        private void btEnterFib_Click(object sender, EventArgs e)
        {
            int n;
            // EL VALOR INGRESADO DEBE SER NUMERICO
            if (int.TryParse(txtboxEscribirFib.Text, out n) && n >= 0)
            {
                // OBTENER SECUENCIA FIBONACCI
                string resultadoFibonacci = fibonacci.ObtenerFibonacci(n);
                // MUESTRA RESULTADO
                textBoxResultadoFib.Text = $"La secuencia de Fibonacci hasta {n} es: {resultadoFibonacci}\n";


                textBoxResultadoFib.Visible = true;
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número entero válido y no negativo.");
            }
        }
    }
}
