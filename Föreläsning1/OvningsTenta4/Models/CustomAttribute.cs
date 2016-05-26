using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OvningsTenta4.Models
{
    public class CustomAttribute
    {
        public class CustomAttributeChecker : ValidationAttribute
        {
            public override bool IsValid(object value)
            {
                if (value == null)
                {
                    return false;
                }
                var toCheck = value.ToString().ToLower();
                return !toCheck.Contains("knife") && !toCheck.Contains("gun") && !toCheck.Contains("fight");

            }

            public override string FormatErrorMessage(string name)
            {
                return "AJa baja: " + name + "Använd inte deessa ord!";
            }
        }
    }
}