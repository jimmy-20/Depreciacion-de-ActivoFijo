using DepreciacionApp.Clases.Model;
using DepreciacionApp.Enums;
using DepreciacionApp.Poco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepreciacionApp.Forms
{
    public partial class FrmRegister : Form
    {
        public FrmViewActivoFijos FrmViewActivoFijos { get; set; }
        public ActivoFijoModel ActivoFijoModel { get; set; }
        public Form1 Form { get; set; }
            
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            cmbTipoActivoFijo.Items.AddRange(Enum.GetValues(typeof(TipoActivoFijo)).Cast<object>().ToArray());
            cmbTipoActivoFijo.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmViewActivoFijos = new FrmViewActivoFijos();
            FrmViewActivoFijos.ActivoFijoModel = ActivoFijoModel;
            FrmViewActivoFijos.MdiParent = Form;
            FrmViewActivoFijos.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int index = cmbTipoActivoFijo.SelectedIndex;
            string costo = txtCosto.Text;
            string residual = txtValorR.Text;
            string image = txtImagen.Text;
            string descripcion = txtDescripcion.Text;

            decimal costoAf = Convert.ToDecimal(costo);
            decimal residualAf = Convert.ToDecimal(residual);
            ActivoFijo af = new ActivoFijo()
            {
                Nombre = nombre,
                TipoActivoFijo = Enum.GetValues(typeof(TipoActivoFijo)).Cast<TipoActivoFijo>().ToArray()[index],
                Costo = costoAf,
                VResidual = residualAf,
                Image = image,
                Descripcion = descripcion
            };

            ActivoFijoModel.Add(af);

            MessageBox.Show("Activo Fijo agregado correctamente", "Mensaje de confirmación", 
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
