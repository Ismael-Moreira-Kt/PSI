using System;

namespace App {
    class Program {
        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());
            int soma = 0;

            for(int i = 0; i <= n; i++) {
                soma += i;
                Console.WriteLine(soma);
            }
        }
    }
}