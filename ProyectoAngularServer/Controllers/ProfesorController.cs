using ProyectoAngularServer.DataAccess;
using ProyectoAngularServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoAngularServer.Controllers
{
    public class ProfesorController : Controller
    {
        private ProfesorDB profesorDB = new ProfesorDB();

        // GET: Teachers
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult guardarProfesor(Profesor profesor)
        {
            profesorDB.profesores.Add(profesor);
            int saveRecords = profesorDB.SaveChanges();
            var result = new { SavedRecords = saveRecords };
            return Json(result);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                profesorDB.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult obtenerProfesores()
        {
            return Json(profesorDB.profesores.ToList(), JsonRequestBehavior.AllowGet);
        }
    }
}
