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
    public class PacienteBl
    {
        public List<Paciente> List(int idUsuario)
        {
            using (var context = new GcoContext())
            {
                var pacientes = context.Pacientes
                    .Where(c => c.IdUsuario.Equals(idUsuario))
                    .Include(t => t.Usuario)
                    .ToList();
                return pacientes;
            }
        }
    }
}
