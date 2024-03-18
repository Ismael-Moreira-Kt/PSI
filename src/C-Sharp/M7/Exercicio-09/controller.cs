using System;
using System.Collections.Generic;
using Produto;

namespace Controller {
    class Controller {
        private List<Produto.Produto> listaDeProdutos = new List<Produto.Produto>();



        public void addNewProduct() {
            Console.WriteLine("Digite o nome do Produto: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o preço do Produto: ");
            int preco = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a quantidade do Produto: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a categoria do Produto: ");
            string categoria = Console.ReadLine();

            Produto.Produto novoProduto = new Produto.Produto(nome, categoria, preco, quantidade);
            listaDeProdutos.Add(novoProduto);        
        }
        


        public void listAllProducts(){
            foreach (var produto in listaDeProdutos) {
                Console.WriteLine("ID " + produto.getID());
                Console.WriteLine("Nome " + produto.getNome());
                Console.WriteLine("Preço " + produto.getPreco());
                Console.WriteLine("Quantidade " + produto.getQuantidade());
                Console.WriteLine("Categoria " + produto.getCategoria());
                Console.WriteLine();
                Console.WriteLine("|---------------------------------------------------------|");
                Console.WriteLine();
                Console.WriteLine();
            }
        }



        public void putProduct(){
            Console.WriteLine("Digite o ID do Produto a alterar: ");
            string inputId = Console.ReadLine();

            if (Guid.TryParse(inputId, out Guid ID)) {
                foreach (var produto in listaDeProdutos) {
                    if (produto.getID() == ID) {
                        Console.WriteLine("Digite o nome do Produto: ");
                        string nome = Console.ReadLine();
                        produto.setNome(nome);

                        Console.WriteLine("Digite o preço do Produto: ");
                        int preco = Convert.ToInt32(Console.ReadLine());
                        produto.setPreco(preco);

                        Console.WriteLine("Digite a quantidade do Produto: ");
                        int quantidade = Convert.ToInt32(Console.ReadLine());
                        produto.setQuantidade(quantidade);

                        Console.WriteLine("Digite a categoria do Produto: ");
                        string categoria = Console.ReadLine();
                        produto.setCategoria(categoria);

                        break;
                    }
                }
            }
        }



        public void deleteProduct(){
            Console.WriteLine("Digite o ID do Produto a deletar: ");
            string inputId = Console.ReadLine();

            if (Guid.TryParse(inputId, out Guid ID)) {
                for (int i = 0; i < listaDeProdutos.Count; i++) {
                    if (listaDeProdutos[i].getID() == ID) {
                        listaDeProdutos.RemoveAt(i);
                        break;
                    }
                }
            }
        }



        public void listByCategoria(){
            Console.WriteLine("Digite a categoria do Produto a ver: ");
            string categoria = Console.ReadLine();

            
            foreach (var produto in listaDeProdutos) {
                if (produto.getCategoria() == categoria) {
                    Console.WriteLine("ID " + produto.getID());
                    Console.WriteLine("Nome " + produto.getNome());
                    Console.WriteLine("Preço " + produto.getPreco());
                    Console.WriteLine("Quantidade " + produto.getQuantidade());
                    Console.WriteLine("Categoria " + produto.getCategoria());
                    Console.WriteLine();
                    Console.WriteLine("|---------------------------------------------------------|");

                    break;
                }
            }
        }
    }
}