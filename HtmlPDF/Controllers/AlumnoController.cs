using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HtmlPDF.Models;

namespace HtmlPDF.Controllers
{
    public class AlumnoController : Controller
    {
        //
        // GET: /Alumno/
        public ActionResult Index()
        {
            Alumno a = new Alumno();
            ViewBag.ListaAlumnos = a.ListaAlumnos();
            ViewBag.NumRegistros = a.ListaAlumnos().Count();

            return View();
        }
	}
}