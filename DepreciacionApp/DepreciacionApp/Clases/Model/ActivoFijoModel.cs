using DepreciacionApp.Poco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepreciacionApp.Clases.Model
{
    public class ActivoFijoModel
    {
        private ActivoFijo[] activosFijos;

        public ActivoFijoModel()
        {

        }

        public void Add(ActivoFijo af)
        {
            if (activosFijos == null)
            {
                activosFijos = new ActivoFijo[1];
                activosFijos[0] = af;
                return;
            }

            ActivoFijo[] temp = new ActivoFijo[activosFijos.Length + 1];
            Array.Copy(activosFijos,temp,activosFijos.Length);
            temp[activosFijos.Length] = af;

            activosFijos = temp;
        }

        public void Edit(ActivoFijo af, int row)
        {

        }

        public ActivoFijo[] GetAll()
        {
            return activosFijos;
        }

        public void Delete(int row)
        {

        }
    }
}
