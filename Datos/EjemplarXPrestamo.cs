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
    
    public partial class EjemplarXPrestamo
    {
        public int IDEjemplar { get; set; }
        public int IDPrestamo { get; set; }
        public Nullable<System.DateTime> FechaDevolucion { get; set; }
    
        public virtual Ejemplar Ejemplar { get; set; }
        public virtual Prestamo Prestamo { get; set; }
    }
}
