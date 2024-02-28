using System;

namespace App {
    class Program {
        static void Main(string[] args) {
            string[] nomes = new string[6];
            char[] genero = new char[6];
            int masculino = 0, feminino = 0;

            for (int i = 0; i < 6; i++) {
                Console.WriteLine("Digite o seu nome: ");
                nomes[i] = Console.ReadLine();
                Console.WriteLine("Digite o seu genero: ");
                genero[i] = Convert.ToChar(Console.ReadLine().ToLower());

                if (genero[i] == 'm') {
                    masculino += 1;
                } else {
                    feminino += 1;
                }
            }

            for (int i = 0; i < 6; i++) {
                Console.WriteLine(nomes[i]);
                Console.WriteLine(genero[i]);
            }

            Console.WriteLine("Total Masculino: " + masculino);
            Console.WriteLine("Total Feminino: " + feminino);
        }
    }
}