using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculate
{
    class hourlyEmployee:Employee 
    {
        private double wage;
        private double houres;
        public double Wage { set; get; }
        public double Houres { set; get; }
        public hourlyEmployee(String fn, String ln, string ssn, double Wg, double Hor) : base(fn, ln, ssn)
        {
            Wage = Wg;
            Houres = Hor;
        }

        public override double Earning()
        {
            if (Houres > 40)
                return 40 * Wage + (Houres - Wage) * Wage * 1.5;
            return Houres * Wage;
        }
        public override string ToString()
        {
            return "\n\n Hourly employee : " + base.ToString() + "Hourly Worked " + Houres.ToString() + "\n Wage : " + Wage; ;
        }
    }
}
