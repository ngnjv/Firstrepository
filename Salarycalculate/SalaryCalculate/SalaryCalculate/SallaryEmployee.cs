using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculate
{
    class SalaryEmployee:Employee 
    {
        private Double weeklysalary;
        public double Weeklysalary
        {
            set
            {
                weeklysalary = value;
            }
            get
            {
                return weeklysalary;
            }
        }
        public SalaryEmployee(String fn,String ln,String SSN,Double salary):base(fn,ln,SSN )
        {
            Weeklysalary = salary;
        }

        public override double Earning()
        {
           return Weeklysalary ;
        }
        public override string ToString()
        {
            return "\n\n Salary Employee " + base.ToString() + "weeklysalary: " + weeklysalary.ToString();
        }
    }
}
