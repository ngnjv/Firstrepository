using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculate
{
    class ClommisionEmployee : Employee
    {
        private double grosssales;
        private double commissionrate;
        public double Grosssales
        {
            set
            {
                grosssales = value;
            }
            get
            {
                return grosssales;
            }
        }
        public double Commisionrate{
            set;
            get;}
        public ClommisionEmployee(String fn,String ln,string ssn,double gr,double cr):base(fn,ln,ssn)
        {
            Grosssales = gr;
            Commisionrate = cr;
        }
        public override double Earning()
        {
            return Grosssales * Commisionrate;
        }
        public override string ToString()
        {
            return "\n\n Commision employee"+base.ToString()+"Gross Rate: "+Grosssales.ToString()+"Commission Rate : "+ Commisionrate.ToString() ;
        }
    }
}
