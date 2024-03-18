using System;
using Controller;

namespace Program {
    class Program {

        public static void Main(string[] args) {
            Controller.Controller controller = new Controller.Controller();

            Console.WriteLine("Bem-vindo ao programa, o que você deseja fazer?");

            do {
               
                Console.WriteLine("1 -> Criar um Produto");
                Console.WriteLine("2 -> Listar todos os Produtos");
                Console.WriteLine("3 -> Atualizar os dados do Produto");
                Console.WriteLine("4 -> Eliminar um Produto");
                Console.WriteLine("5 -> Filtrar por Categoria");
                Console.WriteLine("6 -> Sair");
                int decisao = Convert.ToInt32(Console.ReadLine());
                

                if (decisao == 6) {
                    break;
                }


                switch (decisao) {
                    case 1:
                        controller.addNewProduct();
                        break;

                    case 2: 
                        controller.listAllProducts();
                        break; 
                    
                    case 3: 
                        controller.putProduct();
                        break; 

                    case 4:
                        controller.deleteProduct();
                        break;

                    case 5:
                        controller.listByCategoria();
                        break;

                    default:
                        Console.WriteLine("Opção não reconhecida.");
                        break; 
                }

            } while (true);
        }
    }
}