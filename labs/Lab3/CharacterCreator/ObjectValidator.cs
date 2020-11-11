﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace CharacterCreator
{
   public class ObjectValidator
    {
        public IEnumerable<ValidationResult> TryValidateFullobject (IValidatableObject value)
        {
            var validationResults = new List<ValidationResult>();
            Validator.TryValidateObject(value, new ValidationContext(value), validationResults, true);
            return validationResults;
            

        }
    }
}