using DepreciacionApp.Clases.Model;
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
    public partial class FrmViewActivoFijos : Form
    {
        private DataTable dt;
        public ActivoFijoModel ActivoFijoModel { get; set; }
        public FrmViewActivoFijos()
        {
            InitializeComponent();
            dt = new DataTable();
        }

        private void FrmViewActivoFijos_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Tipo Activo Fijo");
            dt.Columns.Add("Costo");
            dt.Columns.Add("Valor residual");
            dt.Columns.Add("Imagen");
            dt.Columns.Add("Descripción");

            if (ActivoFijoModel.GetAll() == null)
            {
                return;
            }

            foreach(ActivoFijo af in ActivoFijoModel.GetAll())
            {
                DataRow dr = dt.NewRow();
                dr["Nombre"] = af.Nombre;
                dr["Tipo Activo Fijo"] = af.TipoActivoFijo;
                dr["Costo"] = af.Costo;
                dr["Valor Residual"] = af.VResidual;
                dr["Imagen"] = af.Image;
                dr["Descripción"] = af.Descripcion;

                dt.Rows.Add(dr);
            }
            dgvActivoFijos.Rows.Clear();
            dgvActivoFijos.DataSource = dt;
        }

        private void txtFinder(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvActivoFijos.DataSource;
            bs.Filter = $"Nombre like '%{txtBuscar.Text}%'";
            dgvActivoFijos.DataSource = bs;
        }
    }
}
