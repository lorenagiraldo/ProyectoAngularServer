using ProyectoAngularServer.DataAccess;
using ProyectoAngularServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoAngularServer.Controllers
{
    public class RecursoController : Controller
    {
        private RecursoDB recursoDB = new RecursoDB();
        // GET: Recurso
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult guardarRecurso(Recurso recurso)
        {
            recursoDB.recursos.Add(recurso);
            int saveRecords = recursoDB.SaveChanges();
            var result = new { SavedRecords = saveRecords };
            return Json(result);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                recursoDB.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult obtenerRecursos()
        {
            return Json(recursoDB.recursos.ToList(), JsonRequestBehavior.AllowGet);
        }
    }
}