using System;

namespace App {
    class Program {
        static void Main(string[] args) {
            Crescente();
            Decrescente();
        }

        static void Crescente(){
            var rand = new Random();

            int[] list = new int[20];

            for (int ctr = 0; ctr < 20; ctr++) {
                list[ctr] = rand.Next(101);
            }

            Array.Sort(list);

            foreach (int k in list) {
                Console.WriteLine(k);
            }
        }

        static void Decrescente(){
            var rand = new Random();

            double[] list = new double[8];

            for (int ctr = 0; ctr < 8; ctr++) {
                list[ctr] = rand.NextDouble()*1000;
            }

            Array.Reverse(list);

            foreach (double k in list) {
                Console.WriteLine(k.ToString("F2"));
            }
        }
    }
}