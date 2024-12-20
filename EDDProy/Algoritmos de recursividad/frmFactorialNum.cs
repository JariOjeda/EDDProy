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
    public partial class frmFactorialNum : Form
    {
        public frmFactorialNum()
        {
            InitializeComponent();
        }
        Factorial factorial = new Factorial();
        private void EntrarFactorial_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(CuadroTxtFact.Text, out n) && n >= 0)
            {
                // CALCULA FACTORIAL
                long resultado = factorial.fact(n);
                // MUESTRA RESULTADO
                textBoxResultadoFact.Text = $"El factorial de {n} es: {resultado}\n";

                textBoxResultadoFact.Visible = true;
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número entero válido y no negativo.");
            }
        }
    }
}
