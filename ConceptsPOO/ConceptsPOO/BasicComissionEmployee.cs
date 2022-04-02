using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsPOO
{
    public class BasicComissionEmployee : CommissionEmployee
    {
        public decimal Basic { get; set; }

        /*  
         *  Estamos en multi herencia, Employee -> CommissionEmployee -> BasicComissionEmploye 
         *  El metodo que se sobreescribe en BasicComissionEmploye es de la herencia anterio 
         */
        public override decimal GetValueToPay()
        {
            return base.GetValueToPay() + Basic;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tBasic                :{Basic:C2}";
        }
    }
}
