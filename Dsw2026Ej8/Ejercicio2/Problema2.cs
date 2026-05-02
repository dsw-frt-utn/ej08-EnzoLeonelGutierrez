using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Ejercicio2
{
    internal class Problema2
    {
        public string CrearResumenVenta(long productCode, string productDescription, int quantity, decimal unitPrice)
        {
            
            decimal total = (quantity > 0) ? quantity * unitPrice : 0;

            // Crear clase anónima con los datos
            var resumen = new
            {
                Code = productCode,
                Description = productDescription,
                Quantity = quantity,
                Total = total
            };

            // Retornar la cadena en el formato solicitado
            return $"{resumen.Code}-{resumen.Description}-{resumen.Total}";
        }
    }
}

