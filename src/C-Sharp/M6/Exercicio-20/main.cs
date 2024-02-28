using System;

namespace App {
    class Program {
        static void Main(string[] args) {
            IfVersion(3);
            Console.WriteLine("\n\n\n");
            WhileVersion(15);
        }

        static int IfVersion(int n){
            if (n >= 250) {
                return n;
            }

            Console.WriteLine(n);
            return IfVersion(n * 3);
        }

        static void WhileVersion(int n) {
            while (n <= 250) {
                Console.WriteLine(n);
                n *= 3;
            }
        }
    }
}