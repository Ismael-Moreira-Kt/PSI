using System;

namespace App {
    class Program {
        static void Main(string[] args) {
            int[] list = new int[20];
            int sum = 0;

            for (int i = 0; i < list.Length; i++) {
                list[i] = Convert.ToInt32(Console.ReadLine());
            };

            for (int i = 0; i < list.Length; i++) {
                if (list[i] < 10) {
                    sum += list[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
