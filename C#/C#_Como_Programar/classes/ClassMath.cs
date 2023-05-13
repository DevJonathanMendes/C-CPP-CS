// Class Math.
// Alguns métodos.

using System;

class Program
{
    static void Main(string[] args)
    {
        float x = 99.4, y = 97.96;

        Math.Abs(x);     // Valor absoluto.
        Math.Ceiling(x); // Arredonda para o menor inteiro não menor.
        Math.Floor(x);   // Arredonda para o maior inteiro não maior.
        Math.Cos(x);     // conseno trigonométrico em radianos.
        Math.Exp(x);     // Método exponencial. 
        Math.Log(x);     // Logaritmo natural.
        Math.Max(x, y);  // maior valor.
        Math.Min(x, y);  // Menor valor.
        Math.Pow(x, y);  // Elevado à potência.
        Math.Sin(x);     // Seno trigonométrico em radianos.
        Math.Sqrt(x);    // Raiz quadrada.
        Math.Tan(x);     // Tangente trigonométrica em radianos.
    }
}
