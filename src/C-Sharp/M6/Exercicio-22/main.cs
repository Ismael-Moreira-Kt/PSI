using System;

namespace App {
    class Program {
        static void Main(string[] args) {
            double menor = double.PositiveInfinity;
            double maior = double.NegativeInfinity;
            int i = 0;

            while (i < 5) {
                double altura = Convert.ToDouble(Console.ReadLine());

                if (altura > maior) {
                    maior = altura;
                }
                
                if (altura < menor) {
                    menor = altura;
                }

                i++;
            }

            Console.WriteLine("Maior " + maior);
            Console.WriteLine("Menor " + menor);
        }
    }
}