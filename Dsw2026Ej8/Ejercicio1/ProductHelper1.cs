using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Ejercicio1
{
    internal partial class ProductHelper
    {

        public string ObtenerEtiquetaProducto(long code, string description, decimal price)
        {
            // Usa el método auxiliar para formatear el precio
            string precioFormateado = FormatearPrecio(price);

            // Devuelve la etiqueta con el formato solicitado
            return $"[{code}] {description} - {precioFormateado}";
        }
    }


}

