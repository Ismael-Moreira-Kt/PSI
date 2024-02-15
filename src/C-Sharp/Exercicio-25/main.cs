using System;

namespace App {
    class Program {
        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());
            int total = 0;

            for (int i = 0; i <= n; i++) {
                total += i;
                Console.WriteLine(total);
            }
        }
    }
}