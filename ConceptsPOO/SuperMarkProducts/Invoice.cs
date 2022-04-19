using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarkProducts
{
    public class Invoice : Ipay
    {
        private decimal _products;

        public Invoice()
        {
        }

        public decimal Addproduct(Product product)
        {
            return _products += product.ValueToPay();
 
        }
        public decimal ValueToPay()
        {
            return _products;
        }
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
