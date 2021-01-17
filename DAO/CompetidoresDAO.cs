using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CompetidoresDAO
    {
        EA2Entities contexto;
        public CompetidoresDAO(EA2Entities context)
        {
            contexto = context;
        }

        public List<Competidor> ObtenerTodos()
        {

            List<Competidor> listaCompetidores = contexto.Competidor.ToList();
            return listaCompetidores;
        }

        public void GuardarCompetidor(Competidor competidor)
        {
            contexto.Competidor.Add(competidor);
            contexto.SaveChanges();
        }

        public List<Competidor> ObtenerCompetidoresConPremios()
        {
            List<Competidor> listaCompetidores = contexto.Competidor.Where(o => o.Premios.Count != 0).ToList();
            return listaCompetidores;
        }
    }
}
