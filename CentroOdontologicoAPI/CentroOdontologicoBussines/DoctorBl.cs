using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentroOdontologicoData;
using CentroOdontologicoModel;

namespace CentroOdontologicoBussines
{
    public class DoctorBl
    {
        public List<Doctor> List()
        {
            using (var context = new GcoContext())
            {
                return context.Doctores
                    .ToList();
            }
        }
    }
}
