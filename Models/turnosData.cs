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
    
    public partial class turnosData
    {
        public int turID { get; set; }
        public string turNombre { get; set; }
        public string turApellido { get; set; }
        public string turEmail { get; set; }
        public string turTelefono { get; set; }
        public Nullable<System.DateTime> turFecha { get; set; }
        public string turMensaje { get; set; }
        public Nullable<int> turTipoTurno { get; set; }
        public Nullable<int> turHorario { get; set; }
        public Nullable<int> turEstadoTurno { get; set; }
        public Nullable<int> turProfesionales { get; set; }
        public Nullable<int> turDirecciones { get; set; }
    
        public virtual direccionesData direccionesData { get; set; }
        public virtual estadoTurnoData estadoTurnoData { get; set; }
        public virtual horariosData horariosData { get; set; }
        public virtual profesionalesData profesionalesData { get; set; }
        public virtual tipoTurnosData tipoTurnosData { get; set; }
    }
}
