using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Ejercicio5
{
    internal class WholesaleSale : Sale
    {
        public WholesaleSale(decimal amount) : base(amount) { }

        public override decimal CalculateTotal()
        {
            return Amount * 0.9m; // aplica 10% de descuento
        }
    

}
}
