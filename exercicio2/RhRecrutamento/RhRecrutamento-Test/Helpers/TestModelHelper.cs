﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;



namespace RhRecrutamento_Test.Helpers
{
    public class TestModelHelper
    {
        public static IList<ValidationResult> Validate(object model)
        {
            var results = new List<ValidationResult>();
            var validationContext = new ValidationContext(model, null, null);
            Validator.TryValidateObject(model, validationContext, results, true);
            if (model is IValidatableObject) (model as IValidatableObject).Validate(validationContext);
            return results;
        }
    }
}
