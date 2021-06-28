using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepreciacionApp.Clases.Depreciación
{
    public interface IDepreciacion
    {
        decimal[] calcular(decimal costo, decimal residual, int vidaUtil);
    }
}
