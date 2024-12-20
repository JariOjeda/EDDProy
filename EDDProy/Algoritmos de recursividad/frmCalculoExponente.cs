﻿using EDDemo.Algoritmos_de_recursividad.Clases;
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
    public partial class frmCalculoExponente : Form
    {
        Potencia poten = new Potencia();
        public frmCalculoExponente()
        {
            InitializeComponent();
        }

        private void EntrarBoton_Click(object sender, EventArgs e)
        {
            int baseNum, exponente;

            // AMBOS VALORES DEBEN SER NUMERICOS
            if (int.TryParse(EscribirBaseTxtBox.Text, out baseNum) && int.TryParse(ExcribirExponenteTxtBox.Text, out exponente) && exponente >= 0)
            {
                // CALCULA LA POTENCIA
                int resultado = poten.Pot(baseNum, exponente);
                // MUESTRA EL RESULTADO
                ResultadoExpoTxtBox.Text = $"El resultado de {baseNum}^{exponente} es: {resultado}\n";

                ResultadoExpoTxtBox.Visible = true;
            }
            else
            {
                MessageBox.Show("Por favor, ingresa números enteros válidos y no negativos.");
            }
        }

        private void frmCalculoExponente_Load(object sender, EventArgs e)
        {

        }
    }
}
