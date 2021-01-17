using Entidades;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class CantidadTotalPremiosApiController : ApiController
    {
        ServicioPremios servicioPremios;
        public CantidadTotalPremiosApiController()
        {
            EA2Entities context = new EA2Entities();
            servicioPremios = new ServicioPremios(context);
        }
        public string Get(int id)
        {
            int totalPremios = servicioPremios.ConsultarTotalPremiosParaAnioRecibidoPorParametro(id);
            return totalPremios.ToString();
        }
    }
}
