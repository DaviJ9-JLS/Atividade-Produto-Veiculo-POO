using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_12___Produto
{
    class Produto
    { 
        //Variaveis
        private string _name;
        private string _descricao;
        private double _preco;

        //Construtores
        public Produto()
        {
            this._name = ". ";
            this._descricao = ". ";
            this._preco = 0.0;
        }

        //Gets e Sets
        public string getName()
        {
            return this._name;
        }

        public string getDescricao()
        {
            return this._descricao;
        }

        public double getPreco()
        {
            return this._preco;
        }

        public void setName(string name)
        {
            if (name.Length <= 300)
            {
                this._name = name;
            }
        }

        public void setDescricao(string descricao)
        {
            if (descricao.Length <= 5000)
            {
                this._descricao = descricao;
            }
        }

        public void setPreco(double preco)
        {
            if (preco >= 0)
            {
                this._preco = preco;
            }
        }
    }
}