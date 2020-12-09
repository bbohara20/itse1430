/* Name: Bam Bohara
 *Course: ITSE 1430
 *Lab: Character Creator
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace CharacterCreator
{
    public class ObjectValidator
    {
        public IEnumerable<ValidationResult> TryValidateFullobject ( IValidatableObject value )
        {
            var validationResults = new List<ValidationResult>();
            Validator.TryValidateObject(value, new ValidationContext(value), validationResults, true);
            return validationResults;
        }

        public object TryValidateFullObject ( Character character )
        {
            throw new NotImplementedException();
        }
    }
}
