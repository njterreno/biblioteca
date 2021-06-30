using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class clsPrestamos
    {
        public List<Estado> LeerEstados()
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                return BD.Estado.ToList();
            }
        }

        public List<Autor> LeerAutores()
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                return BD.Autor.ToList();
            }
        }

        public List<Libro> LeerLibros()
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                BD.Libro.Include("Categoria");
                BD.Libro.Include("Estado");
                return BD.Libro.ToList();
            }
        }

        public List<Socio> LeerSocios()
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                BD.Socio.Include("Localidad").ToList();
                BD.Socio.Include("Estado").ToList();
                return BD.Socio.ToList();
            }
        }

        public List<Prestamo> LeerPrestamos()
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                BD.Socio.Include("Estado").ToList();
                return BD.Prestamo.ToList();
            }
        }

        public List<Socio> LeerSocioXID(int IDSocio)
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                return BD.Socio.Where(b => b.IDSocio == IDSocio).ToList();
            }
        }

        public List<LibroXPrestamo> LeerPrestamoXID(int IDPrestamo)
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                return BD.LibroXPrestamo.Where(b => b.IDPrestamo == IDPrestamo).ToList();
            }
        }

        public List<Libro> LeerLibroXID(int IDLibro)
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                return BD.Libro.Where(b => b.IDLibro == IDLibro).ToList();
            }
        }

        public List<Estado> LeerEstadosXID(int IDEstado)
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                return BD.Estado.Where(b => b.IDEstado == IDEstado).ToList();
            }
        }

        public List<Socio> LeerSocioXNombre(string NombreSocio)
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                return BD.Socio.Where(b => b.Nombre == NombreSocio).ToList();
            }
        }

        public List<Estado> LeerEstadosXNombre(string NombreEstado)
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                return BD.Estado.Where(b => b.Nombre == NombreEstado).ToList();
            }
        }

        public int CrearPrestamo(Prestamo prestamo)
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                BD.Prestamo.Add(prestamo);
                return BD.SaveChanges();
            }
        }

        public List<Libro> LeerLibroXNombre(string TituloLibro)
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                return BD.Libro.Where(b => b.Titulo == TituloLibro).ToList();
            }
        }

        public int CrearLibroXPrestamo(LibroXPrestamo libroXprestamo)
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                BD.LibroXPrestamo.Add(libroXprestamo);
                return BD.SaveChanges();
            }
        }

        public Prestamo LeerPrestamoXid(int IDPrestamo)
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                return BD.Prestamo.SingleOrDefault(b => b.IDPrestamo == IDPrestamo);
            }
        }

        public int ActualizarPrestamo(Prestamo prestamo)
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                Prestamo c = BD.Prestamo.SingleOrDefault(b => b.IDPrestamo == prestamo.IDPrestamo);
                if (c != null)
                {   
                    c.IDPrestamo = prestamo.IDPrestamo;
                    c.IDSocio = prestamo.IDSocio;
                    c.IDEstado = prestamo.IDEstado;
                    c.FechaPrestamo = prestamo.FechaPrestamo;

                    return BD.SaveChanges();
                }
                else
                    return 0;
            }
        }

        public int ActualizarLibroXPrestamo(LibroXPrestamo libroXprestamo)
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                LibroXPrestamo c = BD.LibroXPrestamo.SingleOrDefault(b => b.IDPrestamo == libroXprestamo.IDPrestamo);
                if (c != null)
                {
                    c.IDPrestamo = libroXprestamo.IDPrestamo;
                    c.IDLibro = libroXprestamo.IDLibro;
                    c.FechaDevolucion = libroXprestamo.FechaDevolucion;

                    return BD.SaveChanges();
                }
                else
                    return 0;
            }
        }

        public List<Libro> LeerLibroXNombreBusqueda(string TituloLibro)
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                return BD.Libro.Where(b => b.Titulo.Contains(TituloLibro)).ToList();
            }
        }

        public List<LibroXPrestamo> LeerLibroXIDBusqueda(int IDLibro)
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                return BD.LibroXPrestamo.Where(b => b.IDLibro == IDLibro).ToList();
            }
        }

        public List<Prestamo> LeerPrestamoXIDBusqueda(int IDPrestamo)
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                return BD.Prestamo.Where(b => b.IDPrestamo == IDPrestamo).ToList();
            }
        }

        public List<Socio> LeerSocioXNombreBusqueda(string NombreSocio)
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                return BD.Socio.Where(b => b.Nombre.Contains(NombreSocio)).ToList();
            }
        }

        public List<Prestamo> LeerPrestamoXIDSocio(int IDSocio)
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                return BD.Prestamo.Where(b => b.IDSocio == IDSocio).ToList();
            }
        }

        public List<Prestamo> LeerPrestamosXIDSocio(int p)
        {
            throw new NotImplementedException();
        }



        public List<LibroXPrestamo> LeerLibroXIDPrestamo(int IDPrestamo)
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                return BD.LibroXPrestamo.Where(b => b.IDLibro == IDPrestamo).ToList();
            }
        }

        public List<Libro> LeerLibroXIDBusquedaXSocio(int IDLibro)
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                return BD.Libro.Where(b => b.IDLibro == IDLibro).ToList();
            }
        }


    }
}
