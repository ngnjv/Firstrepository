using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculate
{
    class BaseplusCommisionEmployee:ClommisionEmployee 
    {
        private Double basesalary;
        public double Basesalary
        {
            set
            {
                basesalary = value;
            }
            get
            {
                return basesalary;
            }
        }
        public BaseplusCommisionEmployee(String fn, String ln, string ssn, double gr, double cr,double bs) : base(fn, ln, ssn, gr, cr)
        {
            Basesalary = bs;
        }
        public override double Earning()
        {
            return Basesalary+ base.Earning();
        }
        public override string ToString()
        {
            return "\n\n Base Salary "+ Basesalary.ToString()+ base.ToString()+"\n Basesalary: "+Basesalary.ToString() ;
        }

    }
}
