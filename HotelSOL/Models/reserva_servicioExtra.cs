//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelSOL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class reserva_servicioExtra
    {
        public int id_servicioExtra { get; set; }
        public Nullable<int> id_reserva { get; set; }
        public Nullable<int> id_extra { get; set; }
        public Nullable<int> id_servicio { get; set; }
    
        public virtual reserva reserva { get; set; }
        public virtual servicioExtra servicioExtra { get; set; }
        public virtual servicioReestauranteOtros servicioReestauranteOtros { get; set; }
    }
}