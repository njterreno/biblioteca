using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Negocio;

namespace Negocio
{
    public class clsSocios
    {
        public  List<Socio> LeerSocios()
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                BD.Socio.Include("Localidad").ToList();
                BD.Socio.Include("Estado").ToList();
                return BD.Socio.ToList();
            }
        }

        public List<Socio> LeerSociosXNombre(string nombre)
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                BD.Socio.Include("Localidad").ToList();
                BD.Socio.Include("Estado").ToList();
                return BD.Socio.Where(b => b.Nombre.Contains(nombre.ToUpper())).ToList();
            }
        }

        public List<Socio> LeerSociosXDNI(int dni)
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {

                BD.Socio.Include("Localidad").ToList();
                BD.Socio.Include("Estado").ToList();
                return BD.Socio.Where(b => b.DNI == dni).ToList();
            }
        }

        public Socio LeerPorID(int IDSocio)
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                return BD.Socio.SingleOrDefault(b => b.IDSocio == IDSocio);
            }
        }

        public int Crear(Socio socio)
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                BD.Socio.Add(socio);
                return BD.SaveChanges();
            }
        }       

        public int Actualizar(Socio socio)
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                Socio c = BD.Socio.SingleOrDefault(b => b.IDSocio == socio.IDSocio);
                if (c != null)
                {
                    c.IDSocio = socio.IDSocio;
                    c.Nombre = socio.Nombre.ToUpper();
                    c.DNI = socio.DNI;
                    c.IDEstado = socio.IDEstado;
                    c.Domicilio = socio.Domicilio;
                    c.IDLocalidad = socio.IDLocalidad;
                    c.Telefono = socio.Telefono;
                    c.Correo = socio.Correo;
                    c.Foto = socio.Foto;

                    return BD.SaveChanges();
                }
                else
                    return 0;
            }
        }

        public List<Localidad> LeerLocalidades()
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                return BD.Localidad.ToList();
            }
        }

        public List<Estado> LeerEstados()
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {                
                return BD.Estado.ToList();
            }
        }

        public List<Estado> LeerEstadoNombre(string Nombre)
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                return BD.Estado.Where(b => b.Nombre == Nombre).ToList();
            }
        }

        public List<Estado> LeerEstadoID(int IDEstado)
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                return BD.Estado.Where(b => b.IDEstado == IDEstado).ToList();
            }
        }
    }    
}
