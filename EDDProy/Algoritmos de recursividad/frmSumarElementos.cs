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
    public partial class frmSumarElementos : Form
    {
        SumarArreglos arreglos = new SumarArreglos();
        public frmSumarElementos()
        {
            InitializeComponent();
        }

        private void btEntrarArreglo_Click(object sender, EventArgs e)
        {
            string[] input = txtboxArregloEscribir.Text.Split(',');
            int[] arreglo = new int[input.Length];

            // CONVIERTE LOS ELEMENTOS DEL ARREGLO DE STRING A INT
            for (int i = 0; i < input.Length; i++)
            {
                if (!int.TryParse(input[i].Trim(), out arreglo[i]))
                {
                    MessageBox.Show("Por favor, ingresa solo números enteros separados por comas.");
                    return;
                }
            }
            int suma = arreglos.Sumar(arreglo);
            // MOSTRAR RESULTADOS
            StringBuilder sb = new StringBuilder();
            sb.Append("Arreglo: ");
            foreach (var item in arreglo)
            {
                sb.Append(item + " ");
            }
            sb.Append($"\nSuma de los elementos: {suma}\n");
            ResultadoArregloTxtBox.Text = sb.ToString();

            ResultadoArregloTxtBox.Visible = true;
        }
    }
}
