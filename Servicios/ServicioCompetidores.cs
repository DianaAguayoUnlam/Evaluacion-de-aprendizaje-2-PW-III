using DAO;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class ServicioCompetidores
    {
        CompetidoresDAO competidoresDAO;

        public ServicioCompetidores(EA2Entities context)
        {
            competidoresDAO = new CompetidoresDAO(context);
        }

        public List<Competidor> ObtenerTodos()
        {
            return competidoresDAO.ObtenerTodos();
        }

        public void GuardarCompetidor(Competidor competidor)
        {
            competidoresDAO.GuardarCompetidor(competidor);
        }

        public List<Competidor> ObtenerCompetidoresConPremios()
        {
            return competidoresDAO.ObtenerCompetidoresConPremios();
        }
    }
}
