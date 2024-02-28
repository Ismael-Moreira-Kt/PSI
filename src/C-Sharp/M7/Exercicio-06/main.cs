using System;
using System.Collections.Generic;

namespace App {
    public class Carro {
        public Carro(){}
        public string Nome { get; set; }
        public int Ano { get; set; }


        public Carro(int ano, string nome) {
            this.Ano = ano;
            this.Nome = nome;
        }
    }


    class Program {

        static List<Carro> carros;

        static void Main(string[] args) {

            carros = new List<Carro>();

            carros.Add(new Carro(1982, "Camry"));
            carros.Add(new Carro(1964, "Mustang"));
            carros.Add(new Carro(1974, "Golf"));

            foreach (Carro c in carros) {
                Console.WriteLine(c.Nome + " " + c.Ano);
            }
        }
    }
}