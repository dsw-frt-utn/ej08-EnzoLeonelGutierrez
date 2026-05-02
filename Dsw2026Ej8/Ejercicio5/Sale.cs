using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Ejercicio5
{
    internal class Sale
    {
  
            protected decimal Amount;

            public Sale(decimal amount)
            {
                Amount = amount;
            }

            // Método virtual que será redefinido
            public virtual decimal CalculateTotal()
            {
                return Amount;
            }
        }
    }
