using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Ejercicio3
{
    internal class Problema3
    {
            public string CompararCopias(int originalValue, Product product)
            {
                // 1. Copiar el valor original en una variable local
                int copiaValor = originalValue;

                // 2. Incrementar solo la copia
                copiaValor++;

                // 3. Copiar la referencia del producto en otra variable local
                Product copiaProducto = product;

                // 4. Modificar la descripción del producto copiado
                copiaProducto.CambiarDescripcion("Producto modificado");

                // 5. Retornar la cadena con el formato solicitado
                return $"{originalValue}-{copiaValor}-{copiaProducto.Description}";
            }
        }
    }
