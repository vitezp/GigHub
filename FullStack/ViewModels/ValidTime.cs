using System;
using System.ComponentModel.DataAnnotations;

namespace FullStack.ViewModels
{
    public class ValidTime : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            bool isValid = true;
            DateTime dateTime;
            if (!DateTime.TryParse(Convert.ToString(value), out dateTime))
            {
                isValid = false;
            }

            return (isValid);
        }
    }
}