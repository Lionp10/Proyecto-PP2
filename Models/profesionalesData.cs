//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sistemaESDO.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class profesionalesData
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public profesionalesData()
        {
            this.turnosData = new HashSet<turnosData>();
        }
    
        public int proID { get; set; }
        public string proApellidoNombre { get; set; }
        public Nullable<int> proDireccionID { get; set; }
    
        public virtual direccionesData direccionesData { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<turnosData> turnosData { get; set; }
    }
}