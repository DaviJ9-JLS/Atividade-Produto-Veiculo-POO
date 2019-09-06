using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_12___Produto
{
    class Comidas
    {
        //Variaveis
        private double _imposto;
        private double _margemLucro;
        private double _lucroTotal;

        //Construtor
        public Comidas()
        {
            this._imposto = 1.18;
            this._margemLucro = 1.25;
            this._lucroTotal = 0;
        }

        //Gets
        public double getImposto()
        {
            return this._imposto;
        }

        public double getMargemLucro()
        {
            return this._margemLucro;
        }

        public double getLucroTotal()
        {

            return this._lucroTotal;
        }

        public void setLucroTotal(double preco)
        {
            this._lucroTotal = preco * this._imposto * this._margemLucro;
        }


        public override string ToString()
        {
            return $"Imposto: {this._imposto}, Margem de Lucro: {this._margemLucro} e lucro Total: {this._lucroTotal}";
        }
    }
}
