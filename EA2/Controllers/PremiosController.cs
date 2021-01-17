using Entidades;
using Servicios;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EA2.Controllers
{
    public class PremiosController : Controller
    {
        ServicioPremios servicioPremios;
        ServicioCompetidores servicioCompetidores;
        public PremiosController()
        {
            EA2Entities context = new EA2Entities();
            servicioPremios = new ServicioPremios(context);
            servicioCompetidores = new ServicioCompetidores(context);
        }
        // GET: Premios
        public ActionResult ListaPremios()
        {
            List<Competidor> listaCompetidores = servicioCompetidores.ObtenerCompetidoresConPremios();
            return View(listaCompetidores);
        }

        [HttpGet]
        public ActionResult AltaPremios()
        {
            var listaCompetidores = servicioCompetidores.ObtenerTodos();
            ViewBag.Competidores = new SelectList(listaCompetidores, "Id", "Nombre");
            return View();
        }

        [HttpPost]
        public ActionResult AltaPremios(Premios premio)
        {
            if (!ModelState.IsValid)
            {
                var listaCompetidores = servicioCompetidores.ObtenerTodos();
                ViewBag.Competidores = new SelectList(listaCompetidores, "Id", "Nombre");
                return View();
            }
            servicioPremios.GuardarPremio(premio);

            return RedirectToAction("ListaPremios");
        }
    }
}