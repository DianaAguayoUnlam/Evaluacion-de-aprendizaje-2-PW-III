using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PremiosDAO
    {
        EA2Entities contexto;
        public PremiosDAO(EA2Entities context)
        {
            contexto = context;
        }
        public void GuardarPremio(Premios premio)
        {
            contexto.Premios.Add(premio);
            contexto.SaveChanges();
        }

        public Premios ConsultarPremioDeCompetidorConMismoAnioIngresado(Premios premio)
        {
            Premios premioConAnioIgualAlIngresado = contexto.Premios.FirstOrDefault(o => o.Año.Equals(premio.Año) && o.Competidor.Id.Equals(premio.IdCompetidor));
            return premioConAnioIgualAlIngresado;
        }

        public void ActualizarCantidadPremios(Premios premioNuevo, Premios premioExistente)
        {
            premioExistente.CantidadPremios = premioNuevo.CantidadPremios;
            contexto.SaveChanges();
        }

        public List<int> ObtenerPremiosRegistradosParaAnioParametro(int anio)
        {
            List<int> TotalPremios = contexto.Premios.Where(o => o.Año.Equals(anio)).Select(o => o.CantidadPremios).ToList();
            return TotalPremios;
        }
    }
}
