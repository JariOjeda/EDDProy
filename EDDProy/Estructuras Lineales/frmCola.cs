using EDDemo.Estructuras_Lineales.Clases;
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
    public partial class frmCola : Form
    {
        Cola cola = new Cola();
        public frmCola()
        {
            InitializeComponent();
        }

        //ACTUALIZA COLA
        private void ActualizarCola()
        {
            var (recorrido, _) = cola.Recorrer();
            TxResultado.Text = recorrido;  // MOSTRAR CONTENIDO EN RESULTADOS
        }

        // MOSTRAR TIEMPO DE EJECUCCION
        private void MostrarTiempoYOperaciones(Stopwatch stopwatch, int operaciones)
        {
            long tiempoMs = stopwatch.ElapsedMilliseconds;
            long tiempoTicks = stopwatch.ElapsedTicks;
            TxInfo.Text = $"Tiempo: {tiempoMs} ms, {tiempoTicks} ticks, Operaciones: {operaciones}";
        }
        private void BtColaVaciar_Click(object sender, EventArgs e)
        {
            cola.Vaciar();
            ActualizarCola();

        }

        private void BtDequeue_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            var (eliminado, operaciones) = cola.Dequeue();
            stopwatch.Stop();

            MessageBox.Show("Elemento desencolado: " + eliminado);
            MostrarTiempoYOperaciones(stopwatch, operaciones);
            ActualizarCola();  // ACTUALIZAR Y MOSTRAR COLA
        }

        private void BtBuscar_Click(object sender, EventArgs e)
        {
            string valor = TxInPut.Text; 
            if (!string.IsNullOrEmpty(valor))
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                var (posicion, operaciones) = cola.Buscar(valor);
                stopwatch.Stop();

                if (posicion >= 0)
                {
                    MessageBox.Show("El dato " + valor + " está en la posición " + posicion);
                }
                else
                {
                    MessageBox.Show("El dato " + valor + " no se encontró en la cola.");
                }

                MostrarTiempoYOperaciones(stopwatch, operaciones);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor para buscar.");
            }
            ActualizarCola(); 
        }

        private void BtQueue_Click(object sender, EventArgs e)
        {
            string dato = TxInPut.Text;  
            if (!string.IsNullOrEmpty(dato))
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                int operaciones = cola.Queue(dato);  // ENCOLAR
                stopwatch.Stop();

                MostrarTiempoYOperaciones(stopwatch, operaciones);
                ActualizarCola();  // MOSTRAR COLA ACTUALIZADA
                TxInPut.Clear();  
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor.");
            }
        }
    }
}
