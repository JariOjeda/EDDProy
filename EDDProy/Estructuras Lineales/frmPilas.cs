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
//using EDDemo.Clases;

namespace EDDemo
{
    public partial class frmPilas : Form
    {
        Pilas pila = new Pilas();
        public frmPilas()
        {
            InitializeComponent();
        }

        //ACTUALIZA LISTA
        private void ActualizarPila()
        {
            var (recorrido, _) = pila.Recorrer();
            TxResultado.Text = recorrido;  
        }

        // MOSTRAR TIEMPO DE EJECUCCION
        private void MostrarTiempoYOperaciones(Stopwatch stopwatch, int operaciones)
        {
            long tiempoMs = stopwatch.ElapsedMilliseconds;
            long tiempoTicks = stopwatch.ElapsedTicks;
            TxInfo.Text = $"Tiempo: {tiempoMs} ms, {tiempoTicks} ticks, Operaciones: {operaciones}";
        }

        private void BtAñadir_Click(object sender, EventArgs e)
        {
            string dato = TxInPut.Text;  // OBTENER DATO
            if (!string.IsNullOrEmpty(dato))
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                int operaciones = pila.Push(dato);  // AÑADIR A PILA
                stopwatch.Stop();

                MostrarTiempoYOperaciones(stopwatch, operaciones);
                ActualizarPila();  // ACTUALIZAR PILA
                TxInPut.Clear();  // LIMPIAR
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor.");
            }
        }

        private void BtBuscar_Click(object sender, EventArgs e)
        {
            string valor = TxInPut.Text;  
            if (!string.IsNullOrEmpty(valor))
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                var (posicion, operaciones) = pila.Buscar(valor);
                stopwatch.Stop();

                if (posicion >= 0)
                {
                    MessageBox.Show("El dato " + valor + " está en la posición " + posicion);
                }
                else
                {
                    MessageBox.Show("El dato " + valor + " no se encontró en la pila.");
                }

                MostrarTiempoYOperaciones(stopwatch, operaciones);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor para buscar.");
            }
            ActualizarPila();  // ACTUALIZAR
        }

        private void BtEliminar_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            var (eliminado, operaciones) = pila.Pop();
            stopwatch.Stop();

            MessageBox.Show("Elemento eliminado: " + eliminado);
            MostrarTiempoYOperaciones(stopwatch, operaciones);
            ActualizarPila();  // ACTUALIZAR PILA
        }

        private void BtPilaVaciar_Click(object sender, EventArgs e)
        {
            pila.Vaciar();
            ActualizarPila();
        }
    }
}
