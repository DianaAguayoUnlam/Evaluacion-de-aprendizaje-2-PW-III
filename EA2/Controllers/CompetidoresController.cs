using Entidades;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EA2.Controllers
{
    public class CompetidoresController : Controller
    {
        ServicioCompetidores servicioCompetidores;
        public CompetidoresController()
        {
            EA2Entities context = new EA2Entities();
            servicioCompetidores = new ServicioCompetidores(context);
        }
        // GET: Competidores
        public ActionResult ListaCompetidores()
        {
            List<Competidor> listaCompetidores = servicioCompetidores.ObtenerTodos();
            return View(listaCompetidores);
        }

        [HttpGet]
        public ActionResult AltaCompetidor()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AltaCompetidor(Competidor competidor)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            else
            {
                servicioCompetidores.GuardarCompetidor(competidor);
            }
            return RedirectToAction("ListaCompetidores");
        }
    }
}