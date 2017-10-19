using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoAngularServer.Controllers
{
    public class ProyectoController : Controller
    {
        // GET: Proyecto
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult guardarProyecto(Proyecto proyecto)
        {
            proyectoDB.proyectos.Add(proyecto);
            int saveRecords = proyectoDB.SaveChanges();
            var result = new { SavedRecords = saveRecords };
            return Json(result);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                proyectoDB.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult obtenerProyectos()
        {
            return Json(proyectoDB.proyectos.ToList(), JsonRequestBehavior.AllowGet);
        }
    }
}
