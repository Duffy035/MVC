using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OvningsTenta3.Models
{
    public class CustomAttribute
    {
        public class CustomCheckAttribute : ValidationAttribute
        {
            public override bool IsValid(object value)
            {
                if (value == null)
                {
                    return false;
                }
                var toCheck = value.ToString().ToLower();
                return !toCheck.Contains("gun") && !toCheck.Contains("knife") && !toCheck.Contains("fight");
            }

            public override string FormatErrorMessage(string name)
            {
                return @"Plz dont use :" + name;
            }
        }
    }
}