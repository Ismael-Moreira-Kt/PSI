using System;

namespace App {
    class Program {
        static void Main(string[] args) {
            double reajuste;

            for (int i = 0; i < 3; i++) {
                Console.WriteLine("Digite o salário: ");
                double salario = Convert.ToDouble(Console.ReadLine());

                if (salario <= 300) {
                    reajuste = (salario * .5) + salario; 
                }
                else {
                    reajuste = (salario * .3) + salario;
                }

                Console.WriteLine("Reajuste: " + reajuste);
            }
        }
    }
}