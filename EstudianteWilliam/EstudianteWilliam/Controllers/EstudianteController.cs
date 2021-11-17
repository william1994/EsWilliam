using EstudianteWilliam.Models;
using EstudianteWilliam.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EstudianteWilliam.Controllers
{
    public class EstudianteController : Controller
    {
        // GET: Estudiante

        ClsREstudiante clsREstudiante = new ClsREstudiante();

        public ActionResult Index()
        {
            var listado = clsREstudiante.ListOfDataOfTableEstudiante();

            return View(listado);
        }

        public ActionResult Delete(int id) {

            estudiante estudiantes = new estudiante();
            estudiantes.idEstudiante = id;


            clsREstudiante.Delete(estudiantes);

            return RedirectToAction("Index");
        
        }
    }
}