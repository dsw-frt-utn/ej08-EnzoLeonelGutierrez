using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Ejercicio5
{
    internal class Problema5
    {
        public decimal ObtenerImporteFinal(Sale sale)
        {
            // Polimorfismo: se ejecuta el método correcto según el tipo real
            return sale.CalculateTotal();
        }
    }

}

