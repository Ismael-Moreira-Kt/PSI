using System;
using System.Collections.Generic;

namespace App {
    class Program {
        static void Main(string[] args) {
            List<string> nomes = new List<string>();
            List<string> produtos = new List<string>();
            int i = 0, escolha;


            while(true) {
                i ++;
                
                Console.WriteLine("Digite um nome:");
                nomes.Add(Console.ReadLine());

                Console.WriteLine("Digite um produto:");
                produtos.Add(Console.ReadLine());

                Console.WriteLine("Quer introduzir mais [1] ou sair? [2]");
                escolha = Convert.ToInt32(Console.ReadLine());            

                if (escolha == 2) {
                    break;
                }
            }

            nomes.Reverse();
            produtos.Reverse();

            foreach (string k in nomes) {
                Console.WriteLine(k);
            }

            Console.WriteLine();

            foreach (string j in produtos) {
                Console.WriteLine(j);
            }
        }
    }
}