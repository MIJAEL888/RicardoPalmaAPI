using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentroOdontologicoData;
using CentroOdontologicoModel;

namespace CentroOdontologicoBussines
{
    public class UsuarioBl
    {
        public Usuario Get(int idUsuario)
        {
            using (var context = new GcoContext())
            {
                return context.Usuarios.Find(idUsuario);
            }
        }
    }
}
