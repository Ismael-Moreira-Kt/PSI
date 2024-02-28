using System;
using System.Linq;

namespace App {
    class Program {
        static void Main(string[] args) {
            int[] list = new int[5] { 101, 2, 13, 432, 5 };

            Array.Sort(list);
            Console.WriteLine(list[0]);

            Array.Reverse(list);
            Console.WriteLine(list[0]);

            Console.WriteLine(list.Sum()/list.Length);
        }
    }
}
