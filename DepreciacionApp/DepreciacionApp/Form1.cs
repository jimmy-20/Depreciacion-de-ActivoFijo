using DepreciacionApp.Clases.Model;
using DepreciacionApp.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepreciacionApp
{
    public partial class Form1 : Form
    {
        private FrmRegister frmRegister;
        private FrmViewActivoFijos frmViewActivoFijos;
        private FrmViewDepreciacion frmViewDepreciacion;
        private ActivoFijoModel activoFijoModel;
        public Form1()
        {
            InitializeComponent();
            activoFijoModel = new ActivoFijoModel();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegister = new FrmRegister();
            frmRegister.MdiParent = this;

            
            frmViewActivoFijos = new FrmViewActivoFijos();
            frmRegister.FrmViewActivoFijos = frmViewActivoFijos;
            frmRegister.ActivoFijoModel = activoFijoModel;
            frmRegister.Form = this;
            frmRegister.Show();
        }

        public void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewActivoFijos = new FrmViewActivoFijos();
            frmViewActivoFijos.ActivoFijoModel = activoFijoModel;
            frmViewActivoFijos.MdiParent = this;
            frmViewActivoFijos.Show();
        }

        private void depreciaciónTotalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewDepreciacion = new FrmViewDepreciacion();
            frmViewDepreciacion.MdiParent = this;
            frmViewDepreciacion.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
