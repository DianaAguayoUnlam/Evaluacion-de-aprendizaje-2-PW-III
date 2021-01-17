using DAO;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class ServicioPremios
    {
        PremiosDAO premiosDAO;
        public ServicioPremios(EA2Entities context)
        {
            premiosDAO = new PremiosDAO(context);
        }
        public void GuardarPremio(Premios premio)
        {
            Premios premioBD = premiosDAO.ConsultarPremioDeCompetidorConMismoAnioIngresado(premio);
            if (premioBD == null)
            {
                premiosDAO.GuardarPremio(premio);
            }
            else
            {
                premiosDAO.ActualizarCantidadPremios(premio, premioBD);
            }
        }

        public int ConsultarTotalPremiosParaAnioRecibidoPorParametro(int anio)
        {
            List<int> TotalPremios = premiosDAO.ObtenerPremiosRegistradosParaAnioParametro(anio);
            int SumaCantidadPremios = 0;
            if (TotalPremios.Count() != 0)
            {
                SumaCantidadPremios = TotalPremios.Sum();
            }
            return SumaCantidadPremios;
        }
    }
}
