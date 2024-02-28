using System;

namespace App {
    class Program {
        static void Main(string[] args) {
            char classificacao;
            int volVendas;
            double premio; 
            string notaQualitativa;

            Console.Write("Qual é o seu volume de vendas atual? ");
            volVendas = Convert.ToInt32(Console.ReadLine());

            if (volVendas <= 19999) {
                classificacao = 'D';
                notaQualitativa = "Mau";
                premio = 0;
            } else if (volVendas >= 2000 && volVendas <= 29999) {
                classificacao = 'C';
                notaQualitativa = "Regular";
                premio = 150;
            } else if (volVendas >= 30000 && volVendas <= 60000) {
                classificacao = 'B';
                notaQualitativa = "Bom";
                premio = 400;
            } else {
                classificacao = 'A';
                notaQualitativa = "Excelente";
                premio = volVendas * .15;
            }

            Console.WriteLine("Classificação: " + classificacao);
            Console.WriteLine("Premio: " + premio);
            Console.WriteLine("Além disso você ganhou: ");

            switch (notaQualitativa) {
                case "Regular":
                    Console.WriteLine("Um jantar.");
                    break;
                case "Bom":
                    Console.WriteLine("Um jantar e uma viagem a madeira.");
                    break;
                case "Excelente":
                    Console.WriteLine("Um jantar, um fim de semana e uma viagem ao brasil.");
                    break;
                default:
                    break;
            }
        }
    }
}