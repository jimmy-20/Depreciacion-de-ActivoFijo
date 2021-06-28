using DepreciacionApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepreciacionApp.Poco
{
    public class ActivoFijo
    {
        public string Nombre { get; set; }
        public TipoActivoFijo TipoActivoFijo { get; set; }
        public decimal Costo { get; set; }
        public decimal VResidual { get; set; }
        public string Image { get; set; }
        public string Descripcion { get; set; }
    }
}
