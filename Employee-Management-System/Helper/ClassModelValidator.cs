using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System.Helper
{
    public static class ClassModelValidator<T> where T : class
    {
        // Errors list for tracking validation issues
        [ThreadStatic]
        private static List<string> Errors;

        static ClassModelValidator()
        {
            Errors = new List<string>();
        }



        public static bool IsValid(T model)
        {
            if (model == null)
            {
                AddError("Model cannot be null.");
                return false;
            }

            Errors.Clear();

            foreach (var property in typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                var value = property.GetValue(model);
                foreach (var attribute in property.GetCustomAttributes<ValidationAttribute>())
                {
                    if (!attribute.IsValid(value))
                    {
                        //AddError($"Property '{property.Name}' validation failed: {attribute.ErrorMessage ?? "Validation failed."}");\
                        AddError(attribute.FormatErrorMessage(property.Name));
                    }
                }
            }

            return Errors.Count == 0;
        }

        public static IEnumerable<string> GetErrors()
        {
            return Errors;
        }

        public static string GetErrorsString()
        {
            return string.Join(Environment.NewLine, Errors);
        }

        private static void AddError(string error)
        {
            if (!string.IsNullOrEmpty(error))
            {
                Errors.Add(error);
            }
        }
    }
}
