using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sistemaESDO.Models.ViewModels
{
    public class TurnosViewModel
    {
        [Display (Name = "Id")]
        public int turnoID { get; set; }

        [Display(Name = "Nombre*")]
        [Required(ErrorMessage = "Ingrese su nombre.")]
        public string turNombre { get; set; }

        [Display(Name = "Apellido*")]
        [Required(ErrorMessage = "Ingrese su apellido.")]
        public string turApellido { get; set; }

        [Display(Name = "Nombre completo")]
        public string turNombreCompleto { get; set; }

        [Display(Name = "Email*")]
        [EmailAddress]
        [Required(ErrorMessage = "Ingrese su email.")]
        public string turEmail { get; set; }

        [Display(Name = "Teléfono*")]
        [Required(ErrorMessage = "Ingrese su nro. de teléfono.")]
        public string turTelefono { get; set; }

        [Display(Name = "Seleccionar fecha*")]
        [Required(ErrorMessage = "Seleccione una fecha.")]
        public DateTime turFecha { get; set; }

        [Display(Name = "Mensaje")]
        public string turMensaje { get; set; }

        // Listados
        [Display(Name = "Seleccionar turno*")]
        public int selTipoTurno { get; set; }
        public string turTipoTurno { get; set; }
        public List<SelectListItem> tipoTurnoList { get; set; }

        [Display(Name = "Seleccionar horario*")]
        public int selHorario { get; set; }
        public string turHorario { get; set; }
        public List<SelectListItem> horariosList { get; set; }

        [Display(Name = "Seleccionar estado")]
        public int selEstadoTruno { get; set; }
        public string turEstadoTurno { get; set; }
        public List<SelectListItem> estadoTurnoList { get; set; }

        [Display(Name = "Seleccionar profesional")]
        public int selProfesionales { get; set; }
        public string turProfesionales { get; set; }
        public List<SelectListItem> profesionalesList { get; set; }

        [Display(Name = "Seleccionar dirección")]
        public int selDirecciones { get; set; }
        public string turDirecciones { get; set; }
        public List<SelectListItem> direccionesList { get; set; }

    }
}