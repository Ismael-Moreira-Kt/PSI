using System;

namespace App {
    class Program {
        static void Main(string[] args) {
            var rand = new Random();
            int randomNumber, i = 0;
            randomNumber = rand.Next(51);

            while (i < 5) {
                i++;

                Console.WriteLine("Enter a number between 0 and 50.");
                int number = Convert.ToInt32(Console.ReadLine());


                if (number == randomNumber) {
                    Console.WriteLine("Congratulations, you got it right!");
                    Console.WriteLine("Got it right in the attempt " + i);
                    break;
                }
                else if (number < randomNumber) {
                    Console.WriteLine("The entered number is smaller than the random number.");
                } 
                else {
                    Console.WriteLine("The entered number is greater than the random number.");
                }


                Console.WriteLine("Do you want to try again [1] or would you rather leave [2]?");
                int attempt = Convert.ToInt32(Console.ReadLine());

                if (attempt == 2) {
                    Console.WriteLine("Bye.");
                    break;
                } 
            }

            Console.WriteLine("The number was " + randomNumber);
        }
    }
}