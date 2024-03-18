using System;

namespace Produto {
    class Produto {
        private Guid ID;
        private string nome;
        private int preco;
        private int quantidade;
        private string categoria;



        public Guid getID(){
            return this.ID;
        }

        public string getNome(){
            return this.nome;
        }

        public string getCategoria(){
            return this.categoria;
        }

        public int getPreco(){
            return this.preco;
        }

        public int getQuantidade(){
            return this.quantidade;
        }



        public void setNome(string nome){
            this.nome = nome;
        }

        public void setCategoria(string categoria){
            this.categoria = categoria;
        }

        public void setPreco(int preco){
            this.preco = preco;
        }

        public void setQuantidade(int quantidade){
            this.quantidade = quantidade;
        }



        public Produto(string nome, string categoria, int preco, int quantidade) {
            this.ID = Guid.NewGuid();
            this.nome = nome;
            this.categoria = categoria;
            this.preco = preco;
            this.quantidade = quantidade;
        }
    }
}