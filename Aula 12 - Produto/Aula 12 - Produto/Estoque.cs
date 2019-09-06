using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_12___Produto
{
    class Estoque
    {
        //Variaveis
        private  Comidas[] _comida = new Comidas[300];
        private  Bebidas[] _bebidas = new Bebidas[300];
        private  MaterialDeLimpeza[] _material = new MaterialDeLimpeza[300];
        private  Produto[] _produto = new Produto[300];
        private string[,] _idProd;

        //Construtor
        public Estoque()
        {
            this._idProd = new string[300, 4]; // Primeira parte do vetor é o id do produto e a segunda é a quantidade vendida e a terceira o lucro total
        }

        //Gets e Sets

        //Metodos

        /// <summary>
        /// Esse metodo server para dá uma caracteristicar e adicionar ao estoque
        /// </summary>
        /// <param name="produto"></param>
        /// <param name="categoria"></param>
        /// <param name="posicao"></param>
        public void addEstoque(Produto produto, string categoria, int posicao)
        {

            this._comida[posicao] = new Comidas();
            this._bebidas[posicao] = new Bebidas();
            this._material[posicao] = new MaterialDeLimpeza();

            //Funções
            switch (categoria)
            {
                case "Comida":
                    if (this._produto[posicao].getName() == produto.getName())
                    {
                        this._comida[posicao].setLucroTotal(produto.getPreco());
                        this._idProd[posicao, 0] = Convert.ToString(posicao);
                        this._idProd[posicao, 1] = Convert.ToString(0);
                        this._idProd[posicao, 2] = Convert.ToString(this._comida[posicao].getLucroTotal());
                        this._idProd[posicao, 3] = "Comida";
                    }
                    break;
                case "Bebida":
                    if (this._produto[posicao].getName() == produto.getName())
                    {
                        this._bebidas[posicao].setLucroTotal(produto.getPreco());
                        this._idProd[posicao, 0] = Convert.ToString(posicao);
                        this._idProd[posicao, 1] = Convert.ToString(0);
                        this._idProd[posicao, 2] = Convert.ToString(this._bebidas[posicao].getLucroTotal());
                        this._idProd[posicao, 3] = "Bebida";
                    }
                    break;
                case "Material":
                    if (this._produto[posicao].getName() == produto.getName())
                    {
                        this._material[posicao].setLucroTotal(produto.getPreco());
                        this._idProd[posicao, 0] = Convert.ToString(posicao);
                        this._idProd[posicao, 1] = Convert.ToString(0);
                        this._idProd[posicao, 2] = Convert.ToString(this._material[posicao].getLucroTotal());
                        this._idProd[posicao, 3] = "Material";
                    }
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Esse metodo server para adicionar uma unidade a mais ao quantidade de produto relacionado ao nome.
        /// </summary>
        /// <param name="name">Nome do produto</param>
        public void venderProd(string name)
        {
            for (int i = 0; i < this._produto.Length - 1; i++)
            {
                try
                {
                    if (this._produto[i].getName() == name)
                    {
                        this._idProd[i, 1] = Convert.ToString(int.Parse(_idProd[i, 1]) + 1);
                        i = this._produto.Length;
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        /// <summary>
        /// Esse metodo adiciona um produto a mais.
        /// </summary>
        /// <param name="name">Nome do produto</param>
        /// <param name="descricao">Descricao do produto</param>
        /// <param name="preco">Preco do produto</param>
        /// <param name="categoria">Categoria do produto</param>
        public void addProduto(string name, string descricao, double preco, string categoria)
        {
            for (int i = 0; i < this._produto.Length - 1; i++)
            {
                if (this._produto[i] == null)
                {
                    this._produto[i] = new Produto();
                    this._produto[i].setName(name);
                    this._produto[i].setDescricao(descricao);
                    this._produto[i].setPreco(preco);
                    addEstoque(this._produto[i], categoria, i);
                    i = this._produto.Length;
                }
            }
        }

        /// <summary>
        /// Tem como objetivo pesquisar dentro dos produtos.
        /// </summary>
        /// <param name="name">Name do produto</param>
        /// <returns>Irá retorna se o nome produto está dentro dos protudos.</returns>
        public bool Pesquisar(string name)
        {
            bool certo = false;
            try
            {
                for (int i = 0; i < this._produto.Length - 1; i++)
                {

                    if (name == this._produto[i].getName())
                    {
                        certo = true;
                        Console.WriteLine("\nItem comprado.");
                        i += this._produto.Length;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("\nNome Incorreto.");
                certo = true;
            }

            return certo; 
        }

        /// <summary>
        /// Server para demonstrar todos valores dos produtos
        /// </summary>
        /// <returns>Retorna a informação completa da classe</returns>
        public string informacao()
        {
            StringBuilder infor = new StringBuilder();
            infor.AppendLine("\n\nInformação estoques: \n");
            for (int i = 0; i < _produto.Length - 1; i++)
            {
                if (this._produto[i] != null)
                {
                    infor.Append($"Id Produtos: {this._idProd[i, 0]};\nProduto: {this._produto[i].getName()};\nQuantidade vendida: {this._idProd[i, 1]};\nPreco Produto: {this._produto[i].getPreco()}" +
                        $"\nPreco com imposto e Margem de lucro: {this._idProd[i, 2]};\nLucro com a venda:{(double.Parse(this._idProd[i, 2]) - this._produto[i].getPreco()) * Convert.ToDouble(this._idProd[i, 1]) };" +
                        $"\nTipo: {this._idProd[i, 3]} \n\n");
                }
            }
            return infor.ToString(); ;
        }

        /// <summary>
        /// Retorna o id para que o usuario possa selecionar
        /// </summary>
        /// <returns>Retorna o id do produto</returns>
        public string getIdEName()
        {
            StringBuilder infor = new StringBuilder();
            infor.Append("\n");
            for (int i = 0; i < _produto.Length; i++)
            {
                if (this._idProd[i, 0] != null)
                {
                    infor.AppendLine($"Id: {this._idProd[i, 0].ToString()}, Nome: {this._produto[i].getName()}");
                }
            }

            return infor.ToString();
        }

        /// <summary>
        /// Retorna o tamnho do vetor produto
        /// </summary>
        /// <returns>retorna um valor inteiro com o tamanho do vetor</returns>
        public int getTamanhoProds()
        {
            return this._produto.Length;
        }
    }
}