using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Ejercicio4
{
    internal class Problema3
    {

        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {

            // Lista de notas válidas
            var notasValidas = new List<int>();

            // Validar cada nota: no nula y entre 0 y 10
            if (nota1.HasValue && nota1.Value >= 0 && nota1.Value <= 10)
                notasValidas.Add(nota1.Value);

            if (nota2.HasValue && nota2.Value >= 0 && nota2.Value <= 10)
                notasValidas.Add(nota2.Value);

            if (nota3.HasValue && nota3.Value >= 0 && nota3.Value <= 10)
                notasValidas.Add(nota3.Value);

            // Si no hay notas válidas, retornar 0
            if (notasValidas.Count == 0)
                return 0;

            // Calcular promedio como double
            return notasValidas.Average();
        }


    }
    
}
