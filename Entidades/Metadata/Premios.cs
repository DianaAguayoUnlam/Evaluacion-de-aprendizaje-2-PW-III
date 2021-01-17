using Entidades.ValidationCustom;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [MetadataType(typeof(PremiosMetadata))]
    public partial class Premios
    {

    }

    public class PremiosMetadata
    {
        [Required]
        [Range(1,50, ErrorMessage ="La cantidad debe ser mayor a 1 menor a 50")]
        public int CantidadPremios { get; set; }

        [Required]
        [CheckAnioMinimo(ErrorMessage = "El año debe estar entre 2010 y el año actual")]
        public int Año { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "El campo Competidor es obligatorio")]
        public int IdCompetidor { get; set; }
        
    }
}
