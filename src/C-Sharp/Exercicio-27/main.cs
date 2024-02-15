using System;

namespace App {
    class Program {
        static void Main(string[] args) {
            int idade = 0;
            string primeiroNome = " ", ultimoNome = " ";

            while (idade < 14 || idade > 18 || primeiroNome.Length < 3) {
                Console.WriteLine("Introduza a sua idade: ");
                idade = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduza o seu primeiro e ultimo nome: ");
                primeiroNome = Console.ReadLine();
                ultimoNome = Console.ReadLine();
            }

            switch (idade) {
                case 14:
                    Console.WriteLine("Aluno automaticamente inscrito em dança.");
                    break;
                case 15:
                    Console.WriteLine("Aluno automaticamente inscrito em futebol.");
                    break;
                case 16:
                    Console.WriteLine("Aluno automaticamente inscrito em andebol.");
                    break;
                case 17:
                    Console.WriteLine("Aluno automaticamente inscrito em basket.");
                    break;
                case 18:
                    Console.WriteLine("Aluno automaticamente inscrito em Rugby.");

                    break;
                default:
                    break;
            }
        }
    }
}