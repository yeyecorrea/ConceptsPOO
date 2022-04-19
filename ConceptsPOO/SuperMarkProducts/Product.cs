using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarkProducts
{
    public abstract class Product : Ipay
    {
        public string Description { get; set; }
        public int Id { get; set; }
        public decimal Price { get; set; }
        public float Tax { get; set; }
        public abstract decimal ValueToPay();

        public override string ToString()
        {
            return $"\n\t{Id}   {Description}" +
                   $"\n\t     Price: {Price}" +
                   $"\n\t     Tax: {Tax:P2}";
        }
    }
}
