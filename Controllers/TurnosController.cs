using sistemaESDO.Models;
using sistemaESDO.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace sistemaESDO.Controllers
{
    public class TurnosController : Controller
    {
        private sistemaESDOEntities db = new sistemaESDOEntities();

        [HttpGet]
        public ActionResult Turnos()
        {
            TurnosViewModel model = new TurnosViewModel();
            model.tipoTurnoList = ListarTipoTurnos();
            model.horariosList = ListarHorarios(null);
            return View(model);
        }

        [HttpPost] 
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Solicitar(TurnosViewModel model) 
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(model);

                turnosData newTurno = new turnosData()
                {
                    turNombre = model.turNombre,
                    turApellido = model.turApellido,
                    turEmail = model.turEmail,
                    turTelefono = model.turTelefono,
                    turFecha = model.turFecha,
                    turMensaje = model.turMensaje,
                    turTipoTurno = model.selTipoTurno,
                    turHorario = model.selHorario,
                    turEstadoTurno = 1,
                    turProfesionales = 3,
                    turDirecciones = 1
                };

                db.turnosData.Add(newTurno);
                await db.SaveChangesAsync();

                TempData["Message"] = "El turno fue solicitado correctamente. Nuestro equipo se pondrá en contacto lo antes posible. <br />" +
                    "Por favor, presta atención a tu buzón de entrada del correo electrónico.";

                return RedirectToAction("Index", "Home");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ActionResult Prueba()
        {
            return View();
        }

        #region --> Listados
        private static List<SelectListItem> ListarTipoTurnos()
        {
            TurnosViewModel model = new TurnosViewModel();
            List<SelectListItem> depositoList = new List<SelectListItem>();

            using (var db = new sistemaESDOEntities())
            {
                var dep = db.tipoTurnosData.ToList();
                foreach (var item in dep)
                {
                    depositoList.Add(new SelectListItem
                    {
                        Text = item.ttNombre.ToUpper(),
                        Value = item.ttID.ToString()
                    });
                }
            }
            return depositoList;
        }

        public JsonResult ObtenerHorarios(int id)
        {
            return Json(ListarHorarios(id), JsonRequestBehavior.AllowGet);
        }

        private static List<SelectListItem> ListarHorarios(int? id)
        {
            using (var db = new sistemaESDOEntities())
            {
                if (id == null)
                {
                    TurnosViewModel model = new TurnosViewModel();
                    List<SelectListItem> horariosList = new List<SelectListItem>();

                    var hor = db.horariosData.ToList();
                    foreach (var item in hor)
                    {
                        horariosList.Add(new SelectListItem
                        {
                            Text = item.horHorarios.ToUpper(),
                            Value = item.horID.ToString(),
                        });
                    }
                    return horariosList;
                }
                else
                {
                    var hor = db.horariosData.Where(x => x.horTipoTurnoID == id)
                        .OrderBy(x => x.horID)
                        .Select(x => new SelectListItem { Value = x.horID.ToString(), Text = x.horHorarios.ToUpper() })
                        .ToList();

                    return hor;
                }
            }
        }
        #endregion
    }
}