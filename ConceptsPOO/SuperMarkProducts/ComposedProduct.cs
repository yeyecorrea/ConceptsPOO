using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarkProducts
{
    public class ComposedProduct : Product
    {
        public float Discount { get; set; }
        public List<Product> Products { get; set; }

        public override decimal ValueToPay()
        {
            return Price - (decimal)Discount;
        }

        public override string ToString()
        {
            return $"        {Id}  {Description}" +
                $"\n\t    Discount: {Discount:P2}" +
                $"\n\t    Products: {Products}" +
                $"\n\t    Value: {ValueToPay():C2}";
        }
    }
}
