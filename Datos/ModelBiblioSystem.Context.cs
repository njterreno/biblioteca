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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BDBiblioSystemEntities3 : DbContext
    {
        public BDBiblioSystemEntities3()
            : base("name=BDBiblioSystemEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Autor> Autor { get; set; }
        public DbSet<AutorXLibro> AutorXLibro { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Editorial> Editorial { get; set; }
        public DbSet<Estado> Estado { get; set; }
        public DbSet<Libro> Libro { get; set; }
        public DbSet<LibroXPrestamo> LibroXPrestamo { get; set; }
        public DbSet<Localidad> Localidad { get; set; }
        public DbSet<Prestamo> Prestamo { get; set; }
        public DbSet<Socio> Socio { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
        public DbSet<Ubicacion> Ubicacion { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
    }
}
