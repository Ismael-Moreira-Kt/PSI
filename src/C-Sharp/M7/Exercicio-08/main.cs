using System;
using System.Collections.Generic;
using System.Linq;

namespace App {
    class Funcionario {
        private string nome;
        private long id;
        private double salario;

        public long getId() {
            return this.id;
        }

        public void setId(long id) {
            this.id = id;
        }

        public string getNome() {
            return this.nome;
        }

        public void setNome(string nome) {
            this.nome = nome;
        }

        public double getSalario() {
            return this.salario;
        }

        public void setSalario(double salario) {
            this.salario = salario;
        }

        public Funcionario(long id, string nome, double salario) {
            setId(id);
            setNome(nome);
            setSalario(salario);
        }

        public Funcionario() {}
    }

    class Program {
        public static List<Funcionario> funcionarios = new List<Funcionario>();

        public static void AdicionarFuncionario(long id, string nome, double salario) {
            funcionarios.Add(new Funcionario(id, nome, salario));
        } 

        public static void ListarFuncionarios() {
            foreach (Funcionario funcionario in funcionarios) {
                Console.WriteLine(
                    funcionario.getId() + " " +
                    funcionario.getNome() + " " +
                    funcionario.getSalario() + " euros."
                );
            }
        }

        public static Funcionario GetFuncionarioById(long id) {
            Funcionario funcionario = funcionarios.FirstOrDefault(
                objeto => objeto.getId() == id
            );

            if (funcionario != null) {
                return funcionario;
            } else {
                Console.WriteLine($"O ID {id} NÃO existe na lista.");
                return null;
            }
        }

        public static void AtualizarSalario(long id, double salario) {
            Funcionario funcionario = GetFuncionarioById(id);
            if (funcionario != null) {
                funcionario.setSalario(salario);
                Console.WriteLine("Salário atualizado.");
            }
        }

        public static void Main(string[] args) {
            funcionarios = new List<Funcionario>();
            string nome;
            long id;
            double salario;

            while (true) {
                Console.WriteLine("O que deseja fazer?");
                Console.WriteLine("1 -> Adicionar um novo funcionário.");
                Console.WriteLine("2 -> Listar os funcionários.");
                Console.WriteLine("3 -> Listar um funcionário.");
                Console.WriteLine("4 -> Atualizar o salário de um funcionário.");
                Console.WriteLine("5 -> Sair.");

                int caso = Convert.ToInt32(Console.ReadLine());

                switch (caso) {
                    case 1:
                        Console.WriteLine("Digite um nome.");
                        nome = Console.ReadLine();
                        
                        Console.WriteLine("Digite um ID.");
                        id = Convert.ToInt64(Console.ReadLine());
                        
                        Console.WriteLine("Digite um Salario.");
                        salario = Convert.ToDouble(Console.ReadLine());

                        AdicionarFuncionario(id, nome, salario);
                        
                        break;
                    case 2: 
                        ListarFuncionarios();
                        
                        break;
                    
                    case 3: 
                        Console.WriteLine("Digite um ID.");
                        id = Convert.ToInt64(Console.ReadLine());

                        Funcionario funcionarioEncontrado = GetFuncionarioById(id);
                        Console.WriteLine($"ID: {funcionarioEncontrado.getId()}, Nome: {funcionarioEncontrado.getNome()}, Salário: {funcionarioEncontrado.getSalario()} euros.");

                        break;

                    case 4:
                        Console.WriteLine("Digite um ID.");
                        id = Convert.ToInt64(Console.ReadLine());
                        
                        Console.WriteLine("Digite um Salario.");
                        salario = Convert.ToDouble(Console.ReadLine());

                        AtualizarSalario(id, salario);
                        
                        break;
                }

                if (caso == 5) {
                    break;
                }
            }
        }
    }
}