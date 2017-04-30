using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentroOdontologicoData;
using CentroOdontologicoModel;

namespace CentroOdontologicoBussines
{
    public class TipoAtencionBl
    {
        public List<TipoAtencion> List()
        {
            using (var context = new GcoContext())
            {
                return context.TipoAtenciones.ToList();
            }
        }
    }
}
