using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Dsw2026Ej8.Ejercicio1
{
    internal partial class ProductHelper
    {
     
        // Método auxiliar para dar formato de moneda
        private string FormatearPrecio(decimal price)
        {
            
            CultureInfo cultura = new CultureInfo("es-AR");
            return price.ToString("C", cultura);
        }
    }

}

