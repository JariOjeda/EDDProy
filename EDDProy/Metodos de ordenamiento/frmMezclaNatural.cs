﻿using System;
using System.Collections.Generic;
using EDDemo.Estructuras_Lineales.Clases;
using EDDemo.Metodos_de_ordenamiento.Clases;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Metodos_de_ordenamiento
{
    public partial class frmMezclaNatural : Form
    {
        ListaSimple lista = new ListaSimple();
        public frmMezclaNatural()
        {
            InitializeComponent();
        }

        private void BtnGenerarLista_Click(object sender, EventArgs e)
        {
            int cantidad;
            if (int.TryParse(TxtNumeroElementos.Text, out cantidad) && cantidad > 0)
            {
                lista = new ListaSimple(); // REINICIAR LISTA
                Random random = new Random();
                string listaTexto = "";

                for (int i = 0; i < cantidad; i++)
                {
                    int numero = random.Next(1, 100);
                    lista.InsertarFinal(numero.ToString());

                    if (i > 0)
                        listaTexto += ", ";

                    listaTexto += numero.ToString();
                }

                TxtLista.Text = listaTexto;
            }
            else
            {
                MessageBox.Show("Ingresa un número válido.");
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (lista == null || lista.Cabeza == null)
            {
                MessageBox.Show("No hay datos en la lista para ordenar.");
                return;
            }

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                lista = MezclaNatural.FuncionMezclaNatural(lista);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al ordenar: {ex.Message}");
                return;
            }
            stopwatch.Stop();

            TxtListaOrdenada.Text = lista.ToString();
            TxtTiempo.Text = $"{stopwatch.ElapsedTicks} ticks";
        }
    }
}
