using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarkProducts
{
    public class VariablePriceProduct : Product
    {
        public string Measurement { get; set; }
        public float Quantity { get; set; }
        public override decimal ValueToPay()
        {
            return Price * (decimal)Quantity;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\t     Measuere: {Measurement}" +
                $"\n\t     Qantity: {Quantity}" +
                $"\n\t     Value: {ValueToPay():C2} \n";
        }
    }
}
