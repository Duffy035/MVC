using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Föreläsning8___TDD_Retro
{
    public class SalesProvision
    {
        public double Salary(double salary)
        {
            if (salary > 0)
            {
                var salesSalary = salary;
                var provision = salesSalary * 0.09;
                var addedSalary = provision;

                return addedSalary;
            }
            else if (salary == 0)
            {
                return 15000;
            }
            else
            {
                throw new Exception("Sale must be more than 0");
            }
        }
    }
}
