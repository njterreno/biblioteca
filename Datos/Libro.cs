//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Libro
    {
        public Libro()
        {
            this.AutorXLibro = new HashSet<AutorXLibro>();
            this.LibroXPrestamo = new HashSet<LibroXPrestamo>();
        }
    
        public int IDLibro { get; set; }
        public int IDCategoria { get; set; }
        public int IDEditorial { get; set; }
        public int IDUbicacion { get; set; }
        public int IDEstado { get; set; }
        public string Titulo { get; set; }
        public string Edicion { get; set; }
        public string ISBN { get; set; }
    
        public virtual Categoria Categoria { get; set; }
        public virtual Editorial Editorial { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual Ubicacion Ubicacion { get; set; }
        public virtual ICollection<AutorXLibro> AutorXLibro { get; set; }
        public virtual ICollection<LibroXPrestamo> LibroXPrestamo { get; set; }
    }
}