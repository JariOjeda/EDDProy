﻿using EDDemo.Estructuras_Lineales.Clases;
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

namespace EDDemo.Estructuras_Lineales
{
    public partial class frmListasDobles : Form
    {
        ListaDoble lista = new ListaDoble();
        public frmListasDobles()
        {
            InitializeComponent();
        }

        //ACTUALIZA LISTA
        private void ActualizarLista()
        {
            var (resultado, _) = lista.RecorrerAdelante();
            TxResultado.Text = resultado;  
        }

        // MOSTRAR TIEMPO DE EJECUCCION
        private void MostrarTiempoYOperaciones(Stopwatch stopwatch, int operaciones)
        {
            long tiempoMs = stopwatch.ElapsedMilliseconds;
            long tiempoTicks = stopwatch.ElapsedTicks;
            TxInfo.Text = $"Tiempo: {tiempoMs} ms, {tiempoTicks} ticks, Operaciones: {operaciones}";
        }

        private void BtInsetarPosicion_Click(object sender, EventArgs e)
        {
            string valor = TxInPut.Text;
            if (int.TryParse(TxPosicion.Text, out int posicion) && !string.IsNullOrEmpty(valor))
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                int operaciones = lista.Insertar(valor, posicion);
                stopwatch.Stop();

                MostrarTiempoYOperaciones(stopwatch, operaciones);
                ActualizarLista();  // ACTUALIZA Y RECCORE HACIA ADELANTE
                TxInPut.Clear();
                TxPosicion.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor y una posición válida.");
            }
        }

        private void BtEliminarPosicion_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TxPosicion.Text, out int posicion))
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                int operaciones = lista.Eliminar(posicion);
                stopwatch.Stop();

                MostrarTiempoYOperaciones(stopwatch, operaciones);
                ActualizarLista();  // ACTUALIZA Y RECCORE HACIA ADELANTE
                TxPosicion.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una posición válida.");
            }
        }

        private void BtBuscar_Click(object sender, EventArgs e)
        {
            string valor = TxInPut.Text;
            if (!string.IsNullOrEmpty(valor))
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                var (posicion, operaciones) = lista.Buscar(valor);
                stopwatch.Stop();

                if (posicion >= 0)
                {
                    MessageBox.Show($"El valor {valor} se encuentra en la posición {posicion}.");
                }
                else
                {
                    MessageBox.Show($"El valor {valor} no se encontró en la lista.");
                }

                MostrarTiempoYOperaciones(stopwatch, operaciones);
                ActualizarLista();  // ACTUALIZA Y RECCORE HACIA ADELANTE
                TxInPut.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor para buscar.");
            }
        }

        private void BtRecorrerAtras_Click(object sender, EventArgs e)
        {
            TxResultado.Clear();  

            Stopwatch stopwatch = Stopwatch.StartNew();
            var (resultado, operaciones) = lista.RecorrerAtras();
            stopwatch.Stop();

            TxResultado.Text = resultado;
            MostrarTiempoYOperaciones(stopwatch, operaciones);
        }

        private void BtListaDVaciar_Click(object sender, EventArgs e)
        {
            while (!lista.estaVacio())
            {
                lista.Eliminar(0);
            }
            ActualizarLista(); // ACTUALIZAR LISTA
            MessageBox.Show("La lista ha sido vaciada");
        }
    }
}
