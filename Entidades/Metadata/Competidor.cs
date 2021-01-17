using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [MetadataType(typeof(CompetidorMetadata))]
    public partial class Competidor
    {
    }

    public class CompetidorMetadata
    {
        [Required(ErrorMessage = "Por favor, ingrese un nombre")]
        [StringLength(100 ,ErrorMessage = "El nombre no puede tener más de 100 letras")]
        public string Nombre { get; set; }
    }
}
