using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculate
{
    abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public String SocialSecurityNumber { private set; get; }
        public Employee(String fn,string ln,string ssn)
        {
            FirstName = fn;
            LastName = ln;
            SocialSecurityNumber = ssn;
        }
        public override string ToString()
        {
            return "\n Name: " + FirstName + " " + "\n LastName: " + LastName + "\n SSN: " + SocialSecurityNumber;

        }
        public abstract double Earning();


    }
}
