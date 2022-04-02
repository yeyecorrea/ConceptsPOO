using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsPOO
{
    /* 
     * Las interface son contratos que nos ayuda a evitar la multi herencia
     * la direfencia a una clase abstrata es que en la herencia una clase solo puede
     * heredar de una sola, mientras que en una interface una clase puede heredar de muchas
     * interfaces
     */
    public interface Ipay
    {
        // Definimos el metodo el cual se va implementar
        public decimal GetValueToPay();
    }
}
