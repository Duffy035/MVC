using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OvningsTenta5.Models
{
    public class CustomAttribute
    {
        public class CustomAttributeCheck : ValidationAttribute
        {
            public override bool IsValid(object value)
            {
                if (value == null)
                {
                    return false;
                }
                var toCheck = value.ToString().ToLower();
                return !toCheck.Contains("Gun") && !toCheck.Contains("knife") && !toCheck.Contains("fight");
                
            }

            public override string FormatErrorMessage(string name)
            {
                return "@Dont use the words: gun, knife or fight";
            }
        }
    }
}