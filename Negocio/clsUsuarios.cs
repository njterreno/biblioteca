using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class clsUsuarios
    {
        public int CrearUsuario(Usuario usuario)
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                BD.Usuario.Add(usuario);
                return BD.SaveChanges();
            }
        }

        public List<Usuario> LeerUsuarios()
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                return BD.Usuario.ToList();
            }
        }

        public List<Usuario> LeerUsuarioXNombre(string nombre)
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                return BD.Usuario.Where(b => b.Nombre == nombre).ToList();
            } 
        }

        public List<Usuario> LeerUsuarioXID(int IDUsuario)
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                return BD.Usuario.Where(b => b.IDUsuario == IDUsuario).ToList();
            }
        }
    }
}
