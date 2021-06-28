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
        public Form1()
        {
            InitializeComponent();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegister = new FrmRegister();
            frmRegister.MdiParent = this;
            frmRegister.Show();
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewActivoFijos = new FrmViewActivoFijos();
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
    }
}
