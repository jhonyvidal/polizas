//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Polizas.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Poliza
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Poliza()
        {
            this.CoberturaPoliza = new HashSet<CoberturaPoliza>();
        }
    
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Nullable<decimal> ValorCubierto { get; set; }
        public int id_cliente { get; set; }
        public Nullable<int> id_automotor { get; set; }
        public Nullable<System.DateTime> fechaInicio { get; set; }
        public Nullable<System.DateTime> fechaFin { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoberturaPoliza> CoberturaPoliza { get; set; }
        public virtual Automotor Automotor { get; set; }
    }
}