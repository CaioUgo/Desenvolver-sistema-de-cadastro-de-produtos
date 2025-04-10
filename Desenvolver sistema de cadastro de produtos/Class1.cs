using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desenvolver_sistema_de_cadastro_de_produtos
{
    class Produto
    {
        //atributos
        private string nome;
        private string categoria;
        private decimal preco;
        //métodos get e set
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        public decimal Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        //métodos
        public Produto(string nome, string categoria, decimal preco)
        {
            this.nome = nome;
            this.categoria = categoria;
            this.preco = preco;
        }

        public string ExibirInformacoes()
        {
            return $"Nome: {nome}, Categoria: {categoria}, Preço: R${preco:F2}";
        }


        //método responsável por cadastrar produtos
        public void cadastrarProduto()
        {

            // código para cadastrar produto
        }
    }

}
