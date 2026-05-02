using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Ejercicio3
{
    internal class Product
    {

        public string Description { get; private set; }

        public Product(string description)
        {
            Description = description;
        }

        public void CambiarDescripcion(string nuevaDescripcion)
        {
            Description = nuevaDescripcion;
        }

    }
}
