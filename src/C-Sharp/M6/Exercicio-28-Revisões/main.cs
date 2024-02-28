using System;

namespace App {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite dois números [menor; maior;]");
            int n = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());
            int pares = 0, impares = 0;

            for(int i = n; i <= k; i++) {
                if (i % 2 == 0) {
                    pares += 1;
                } else {
                    impares += 1;
                }
            }

            Console.WriteLine("Pares " + pares);
            Console.WriteLine("Impares " + impares);
        }
    }
}