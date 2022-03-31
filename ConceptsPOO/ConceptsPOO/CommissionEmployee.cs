using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsPOO
{
    public class CommissionEmployee : Employee
    {
        public float CommissionPorcentaje { get; set; }
        public decimal Sales { get; set; }
        public override decimal GetValueToPay()
        {
            return Sales * (decimal)CommissionPorcentaje;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" + 
                $"\n\tCommission Porcentaje: {CommissionPorcentaje:P2}" +
                $"\n\tSales                : {Sales:C2}" +
                $"\n\tValue to pay : {GetValueToPay():C2}";
        }
    }
}
