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
    public class TurnoBl
    {
        public List<Turno> List(int idDoctor)
        {
            using (var context = new GcoContext())
            {
                var results = (from t in context.Turnos
                               join d in context.Pacientes on t.IdDoctor equals d.Id
                               where t.EstadoTurno == EstadoTurno.Libre
                               select t)
                    .Include(c => c.Doctor)
                    .Include(c => c.Sala)
                    .ToList();
                return results;
            }
        }
    }
}
