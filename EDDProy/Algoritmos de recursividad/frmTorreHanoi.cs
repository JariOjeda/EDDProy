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
    public partial class frmTorreHanoi : Form
    {
        TorresDeHanoi hanoi = new TorresDeHanoi();
        public frmTorreHanoi()
        {
            InitializeComponent();
        }

        private void btEjecutarHanoi_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(LeerDiscosTxtBox.Text, out n) && n >= 1)
            {
                // ACUMULAR RESULTADO CON STRINGBUILDER
                StringBuilder resultado = new StringBuilder();
                // EJECUTAR ALGORITMO
                hanoi.MoverDiscos(n, 'A', 'C', 'B', resultado);
                // MOSTRAR RESULTADO
                ResultadoHanoiTxtBox.Text = resultado.ToString();


                ResultadoHanoiTxtBox.Visible = true;
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número entero válido y mayor o igual a 1.");
            }
        }
    }
}
