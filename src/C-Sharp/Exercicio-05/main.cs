using System;

namespace Program
{
	class Program
	{
		static void Main(string[] args)
		{
				int calculo = (58+3)*(15-2);
				double calculoDois = 40/9;
				int resto = 75%3;
				
				string nome;
				int idade;
				
				Console.WriteLine("Digite o seu nome e a sua idade: ")
				nome = Console.Read();
				idade = Convert.ToInt32(Console.Read());
				
				Console.Write("O meu nome é " + nome + " e tenho " + idade + "anos de idade");
		}
	}
}