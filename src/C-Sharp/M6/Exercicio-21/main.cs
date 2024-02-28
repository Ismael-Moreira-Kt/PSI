using System;

namespace App {
    class Program {
        static void Main(string[] args) {
            double[] notas = new double[4];
            double media, soma = 0;
            int i = 0;

            while (i < notas.Length) {
                double nota = Convert.ToDouble(Console.ReadLine());

                if (nota < 0) {
                    i--;
                    Console.WriteLine("Valor inválido!");
                } else {
                    notas[i] = nota;
                    soma += nota;
                }

                i++;
            }

            media = soma / notas.Length;

            for (int j = 0; j < notas.Length; j++) {
                Console.WriteLine("Nota " + (j+1) + ": " + notas[j]);
            }

            Console.WriteLine("Média: " + media);

            if (media < 9.5) {
                Console.Write("Reprovado!");
            } else if (media >= 9.5 && media < 17) {
                Console.Write("Aprovado!");
            } else {
                Console.Write("Defesa oral.");
            }
        }
    }
}