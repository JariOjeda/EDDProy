using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Algoritmos_de_recursividad;
using EDDemo.Algoritmos_de_recursividad.Clases;
using EDDemo.Estructuras_Lineales;
using EDDemo.Estructuras_No_Lineales;
using EDDemo.Metodos_de_busqueda;
using EDDemo.Metodos_de_ordenamiento;

namespace EDDemo
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pilasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPilas mPilas = new frmPilas();
            mPilas.MdiParent = this;
            mPilas.Show();
        }

        private void estructurasLinealesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void arbolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArboles mArboles = new frmArboles();
            mArboles.MdiParent = this;
            mArboles.Show();
        }

        private void factorialDeUnNumeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFactorialNum mFactorial = new frmFactorialNum();
            mFactorial.MdiParent = this;
            mFactorial.Show();
        }

        private void calculoDeUnExponenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalculoExponente mPotencia = new frmCalculoExponente();
            mPotencia.MdiParent = this;
            mPotencia.Show();
        }

        private void sumarElementosDeUnArregloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSumarElementos mSumarArreglo = new frmSumarElementos();
            mSumarArreglo.MdiParent = this;
            mSumarArreglo.Show();
        }

        private void secuenciaDeFibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSecuenciaFibonacci mFibonacci = new frmSecuenciaFibonacci();
            mFibonacci.MdiParent = this;
            mFibonacci.Show();
        }

        private void busquedaBinariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBusquedaBinaria mBusquedaBinaira = new FrmBusquedaBinaria();
            mBusquedaBinaira.MdiParent = this;
            mBusquedaBinaira.Show();
        }

        private void algoritmoDeLaTorreDeHanoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTorreHanoi mTorresDeHnaoi = new frmTorreHanoi();
            mTorresDeHnaoi.MdiParent = this;
            mTorresDeHnaoi.Show(); 
        }

        private void hashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHash mHash = new frmHash();
            mHash.MdiParent = this;
            mHash.Show();
        }

        private void busquedaBinariaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmBusquedaBinaria mBusquedaBinaria = new FrmBusquedaBinaria();
            mBusquedaBinaria.MdiParent = this;
            mBusquedaBinaria.Show();
        }

        private void colasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCola mCola = new frmCola();
            mCola.MdiParent = this;
            mCola.Show();
        }

        private void listaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListasSimples mListasSimples = new frmListasSimples();
            mListasSimples.MdiParent = this;
            mListasSimples.Show();
        }

        private void listaDobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListasDobles mListasDobles = new frmListasDobles();
            mListasDobles.MdiParent = this;
            mListasDobles.Show();
        }

        private void listaCircularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListasCirculares mListasCirculares = new frmListasCirculares();
            mListasCirculares.MdiParent = this;
            mListasCirculares.Show();
        }

        private void listaCircularDobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListasCircularesDobles mListasCircularesD = new frmListasCircularesDobles();
            mListasCircularesD.MdiParent = this;
            mListasCircularesD.Show();
        }

        private void mezlcaDirectaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMezclaDirecta mMezclaDirecta = new frmMezclaDirecta();
            mMezclaDirecta.MdiParent = this;
            mMezclaDirecta.Show();
        }

        private void mezclaNaturalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMezclaNatural mMezclaNatural = new frmMezclaNatural();
            mMezclaNatural.MdiParent = this;
            mMezclaNatural.Show();
        }

        private void burbujaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBurbuja mBurbuja = new frmBurbuja();
            mBurbuja.MdiParent = this;
            mBurbuja.Show();
        }

        private void intercalacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIntercalacion mIntercalacion = new frmIntercalacion();
            mIntercalacion.MdiParent = this;
            mIntercalacion.Show();
        }

        private void quickSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuickSort mQuicksort = new frmQuickSort();
            mQuicksort.MdiParent = this;
            mQuicksort.Show();
        }

        private void radixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRadix mRadix = new frmRadix();
            mRadix.MdiParent = this;
            mRadix.Show();
        }

        private void shellSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShellSort mShellsort = new frmShellSort();
            mShellsort.MdiParent = this;
            mShellsort.Show();
        }
    }
}
