using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HashNamespace;
using System.Collections;
using System.Diagnostics;
using System.IO;

namespace EDDemo.Metodos_de_busqueda
{
    public partial class frmHash : Form
    {
        private Hash tablaHash = new Hash();
        private const string archivoHash = "ClavesHash.txt";
        public frmHash()
        {
            InitializeComponent();
        }

        private void BtnGenerarClave_Click(object sender, EventArgs e)
        {
            string producto = TxtProducto.Text.Trim();
            if (!string.IsNullOrEmpty(producto))
            {
                int clave = Hash.FuncionHashPolinomial(producto, 100); // GENERA CLAVE HASH
                tablaHash.Insertar(clave, producto);

                // GUARDAR CLAVE Y PRODUCTO EN ARCHIVO
                using (StreamWriter writer = new StreamWriter(archivoHash, true))
                {
                    writer.WriteLine($"{clave},{producto}");
                }

                // MOSTRAR
                TxtClaves.AppendText($"Clave: {clave} - Producto: {producto}\r\n");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un producto.");
            }
        }

        private void BtnBuscarClave_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TxtClaveABuscar.Text.Trim(), out int clave))
            {
                // INICIAR TEMP
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                string resultado = tablaHash.Buscar(clave);
                if (resultado != null)
                {
                    TxtResultado.Text = $"Productos: {resultado.Replace(" -> null", "")}";
                }
                else
                {
                    TxtResultado.Text = "No se encontró ningún producto para esta clave.";
                }
                // DETENER TEMP
                stopwatch.Stop();

                // MOSTRAR TIEMPO EN TICKS
                LblTiempo.Text = $"Tiempo de búsqueda: {stopwatch.ElapsedTicks} ticks";
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una clave válida.");
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            tablaHash.VaciarTabla(); // VACIAR TABLA
            File.WriteAllText(archivoHash, string.Empty); // LIMPIAR
            TxtClaves.Clear(); // LIMPIAR TEXT DE LAS CLAVES
            TxtResultado.Clear(); // LIMPIAR RESULTADO
            MessageBox.Show("Tabla hash y archivo limpiados.");
        }
    }
}
