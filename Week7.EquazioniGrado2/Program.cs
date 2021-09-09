using System;
using Week7.EquazioniGrado2.Core;

namespace Week7.EquazioniGrado2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Equazione di Secondo Grado!");
            Console.WriteLine("Immetti i 3 coefficienti dell'equazione completa ax^2 + bx + c=0:");
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c=");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine($"L'equezione da risolvere è: {a}x^2 + {b}x + c=0");

            Equation eq = new Equation();
            double[] risultato = eq.RisolviequazioniDiSecondoGrado(a, b, c);
            if (risultato == null)
            {
                Console.WriteLine("Equazione impossibile");
            }
            else if (risultato.Length == 1)
            {
                Console.WriteLine($"Risultato: x1=x2={risultato[0]}");
            }
            else if (risultato.Length == 2)
            {
                Console.WriteLine($"Risultati: x1={risultato[0]}  x2={risultato[1]}");
            }
        }
    }
}
