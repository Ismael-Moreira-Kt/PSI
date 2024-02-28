using System;

namespace App {
    class Program {
        static void Main(string[] args) {
            double n1 = Convert.ToDouble(Console.ReadLine());
            double n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("1 -> Soma");
            Console.WriteLine("2 -> Subtração");
            Console.WriteLine("3 -> Multiplicação");
            Console.WriteLine("4 -> Divisão");
            int decisao = Convert.ToInt32(Console.ReadLine());

            switch (decisao) {
                case 1:
                    Console.Write(n1+n2);
                    break;
                case 2:
                    Console.Write(n1-n2);
                    break;
                case 3:
                    Console.Write(n1*n2);
                    break;
                case 4:
                    Console.Write(n1/n2);
                    break;
                default:
                    Console.Write("Número inválido!");
                    break;
            }

        }
    }
}