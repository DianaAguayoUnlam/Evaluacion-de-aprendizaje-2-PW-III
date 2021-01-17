using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ValidationCustom
{
    public class CheckAnioMinimo : ValidationAttribute
    {
        public override bool IsValid(object anioInput)
        {
            int anioQueViene = DateTime.Now.Year + 1;
            if (anioInput == null)
            {
                return false;
            }
            if (!((int)anioInput > 2010 && (int)anioInput < anioQueViene))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
