using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Nile
{
   public class ObjectValidator
    {
       public IEnumerable<ValidationResult> TryValidateFullobject ( IValidatableObject value )
        {
            var validationResults = new List<ValidationResult>();
            Validator.TryValidateObject(value, new ValidationContext(value), validationResults, true);
            return validationResults;
        }

    }
}
