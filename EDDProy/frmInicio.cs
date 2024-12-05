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
using EDDemo.Estructuras_No_Lineales;

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
    }
}
