using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class clsLibros
    {
        public List<Libro> LeerLibros()
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                BD.Libro.Include("Categoria");
                BD.Libro.Include("Estado");               
                return BD.Libro.ToList();
            }
        }

        public List<Autor> LeerAutores()
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {                
                return BD.Autor.ToList();
            }
        }

        public Libro LeerPorID(int IDLibro)
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                return BD.Libro.SingleOrDefault(b => b.IDLibro == IDLibro);
            }
        }

        public List<Libro> LeerLibrosXTitulo(string titulo)
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                BD.Libro.Include("Categoria");
                return BD.Libro.Where(b => b.Titulo.Contains(titulo.ToUpper())).ToList();
            }
        }

        public List<Libro> LeerLibrosXID(int IDLibro)
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                BD.Libro.Include("Categoria");
                return BD.Libro.Where(b => b.IDLibro == IDLibro).ToList();
            }
        }

        public List<Autor> LeerAutorXNombreBusqueda(string autor)
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                return BD.Autor.Where(b => b.Nombre.Contains(autor)).ToList();
            }
        }

        public List<AutorXLibro> LeerLibrosXAutor(int IDAutor)
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                return BD.AutorXLibro.Where(b => b.IDAutor == IDAutor).ToList();
            }
        }

        public List<Libro> LeerLibrosXCategoria(string categoria)
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                return BD.Libro.Where(b => b.Categoria.Nombre == categoria).ToList();
            }
        }

        public int CrearLibro(Libro libro)
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                BD.Libro.Add(libro);
                return BD.SaveChanges();
            }
        }

        public List<Autor> LeerAutorXNombre(string Nombre)
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                return BD.Autor.Where(b => b.Nombre == Nombre).ToList();
            }
        }

        public int CrearAutor(Autor autor)
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                BD.Autor.Add(autor);
                return BD.SaveChanges();
            }
        }

        public int CrearAutorXLibro(AutorXLibro autorXlibro)
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                BD.AutorXLibro.Add(autorXlibro);
                return BD.SaveChanges();
            }
        }

        public int ActualizarLibro(Libro libro)
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                Libro c = BD.Libro.SingleOrDefault(b => b.IDLibro == libro.IDLibro);
                if (c != null)
                {
                    c.IDLibro = libro.IDLibro;
                    c.Titulo = libro.Titulo;
                    c.IDEditorial = libro.IDEditorial;
                    c.Edicion = libro.Edicion;
                    c.IDEstado = libro.IDEstado;
                    c.ISBN = libro.ISBN;
                    c.IDCategoria = libro.IDCategoria;                    
                    
                    return BD.SaveChanges();
                }
                else
                    return 0;
            }
        }

        public int ActualizarAutorXLibro(AutorXLibro autorXlibro)
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                AutorXLibro c = BD.AutorXLibro.SingleOrDefault(b => b.IDAutorXLibro == autorXlibro.IDAutorXLibro);
                if (c != null)
                {
                    c.IDAutorXLibro = autorXlibro.IDAutor;

                    return BD.SaveChanges();
                }
                else
                    return 0;
            }
        }

        public List<Categoria> LeerCategorias()
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                return BD.Categoria.ToList();
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

        public List<AutorXLibro>  LeerIDAutores(int IDLibro)
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                return BD.AutorXLibro.Where(b => b.IDLibro == IDLibro).ToList();
            }
        }

        public List<Autor> LeerNombreAutores(int IDAutor)
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                return BD.Autor.Where(b => b.IDAutor == IDAutor).ToList();
            }
        }

        public List<Categoria> LeerNombreCategoria(int IDCategoria)
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                return BD.Categoria.Where(b => b.IDCategoria == IDCategoria).ToList();
            }
        }

        public List<Estado> LeerNombreEstado(int IDEstado)
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                return BD.Estado.Where(b => b.IDEstado == IDEstado).ToList();
            }
        }

        public List<Ubicacion> LeerNombreUbicacion(int IDUbicacion)
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                return BD.Ubicacion.Where(b => b.IDUbicacion == IDUbicacion).ToList();
            }
        }

        public int CrearUbicacion(Ubicacion ubicacion)
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                BD.Ubicacion.Add(ubicacion);
                return BD.SaveChanges();
            }
        }

        public List<Ubicacion> LeerIDUbicacion(string Nombre)
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                return BD.Ubicacion.Where(b => b.Nombre == Nombre).ToList();
            }
        }

        public int CrearEditorial(Editorial editorial)
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                BD.Editorial.Add(editorial);
                return BD.SaveChanges();
            }
        }

        public List<Editorial> LeerIDEditorial(string Nombre)
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                return BD.Editorial.Where(b => b.Nombre == Nombre).ToList();
            }
        }        

        public List<Editorial> LeerNombreEditorial(int IDEditorial)
        {
            using (BDBiblioSystemEntities3 BD = new BDBiblioSystemEntities3())
            {
                return BD.Editorial.Where(b => b.IDEditorial == IDEditorial).ToList();
            }
        }       
    }
}
