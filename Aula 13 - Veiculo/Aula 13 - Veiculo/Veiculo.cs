using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_13___Veiculo
{
    class Veiculo
    {
        //Atributos
        private static bool _ligado;
        private static int _tanque;
        private int _maxTanque;
        private string _name;
        private int _quilometragem;
        private Etanol _etanol;
        private Alcool _alcool;

        //Variaveis auxiliares
        private int _aux = 0;
        private int _tipoCombustivel;

        //Construtor

        /// <summary>
        /// Construtor de veiculo
        /// </summary>
        /// <param name="name">Colocar um nome ao veiculo</param>
        /// <param name="tipoCombustivel">Tipo do combustivel</param>
        /// <param name="tipoTanquec">Qual é o tanque do carro, se é de 40 ou 50</param>
        public Veiculo(string name, int tipoCombustivel, int tipoTanque)
        {
            _ligado = false;
            if (tipoTanque == 1) _tanque = this._maxTanque = 40; // Veiculo com tanque de 40
            if (tipoTanque == 2) _tanque = this._maxTanque = 50; // Veiculo com tanque de 50
            if (tipoCombustivel == 1) { this._alcool = new Alcool(); _tipoCombustivel = 1; } // Veiculo com tanque do tipo alcool
            if (tipoCombustivel == 2) { this._etanol = new Etanol(); _tipoCombustivel = 2; } // Veiculo com tanque do tipo etanol
            this._name = name;
        }

        /// <summary>
        /// Adiciona a quilometragem em relação a alcool
        /// </summary>
        /// <returns>Retorna se foi possivel adicionar a quilometragem</returns>
        public bool addQuilometragemAlcool()
        {
            this._quilometragem++;
            if (_tanque > 5)
            {
                if (this._aux < this._alcool.getConsumoCombustivel()) { _tanque--; this._aux = 0; return true; }
                else { this._aux++; return true; }
            }
            else
            {
                _ligado = false;
                return false;
            }
        }

        /// <summary>
        /// Adiciona a quilometragem em relação a etanol
        /// </summary>
        /// <returns>Retorna se foi possivel adicionar a quilometragem</returns>
        public bool addQuilometragemEtanol()
        {
            this._quilometragem++;
            if (_tanque > 5)
            {
                if (this._aux < this._etanol.getConsumoCombustivel()) { _tanque--; this._aux = 0; return true; }
                else { this._aux++; return true; }
            }
            else
            {
                _ligado = false;
                return false;
            }
        }

        /// <summary>
        /// Redireciona para que possa ser adicionado a quilometragem de acordo com o tipo
        /// </summary>
        /// <returns>Retorna se foi possivel adicionar</returns>
        public bool addquilometragemTipoComb()
        {
            bool aux2 = false;
            if (_ligado == true)
            {
                if (_tipoCombustivel == 1) { aux2 = addQuilometragemAlcool(); }
                if (_tipoCombustivel == 2) { aux2 = addQuilometragemEtanol(); }
            }
            return aux2;
        }


        /// <summary>
        /// Esse metodo verificar o estado do tanque
        /// </summary>
        /// <returns>Os retornos possiveis são 2. 1 - Tanque com combustivel, 2 - Tanque abaixo de 5 litros(Reserva)</returns>
        public string verificarTanque()
        {
            if (_tanque < 5)
            {
                return "Tanque com combustivel.";
            }
            else
            {
                return "Tanque abaixo.";
            }
        }

        /// <summary>
        /// adicionar uma quantidade ao tanque limitando de acordo com o tipo do tanque
        /// </summary>
        /// <param name="quantidade">a quantidade que deseja adicionar</param>
        private void setTanque(int quantidade)
        {
            if (_tanque + quantidade < 50 && _tanque + quantidade > 0 && _maxTanque == 50)
            {
                _tanque += quantidade;
            }
            else if (_tanque + quantidade > 0)
            {
                _tanque = 50;
            }
            if (_tanque + quantidade < 40 && _tanque + quantidade > 0 && _maxTanque == 40)
            {
                _tanque += quantidade;
            }
            else if (_tanque + quantidade > 0)
            {
                _tanque = 50;
            }
        }

        /// <summary>
        /// Metodo feito para reabastecer o tanque
        /// </summary>
        /// <param name="quantidade">Quantidade a ser adicionada ao tanque.</param>
        /// <returns></returns>
        public int reabastecer(int quantidade)
        {
            int quant = 0;
            if (CalcularTanque() + quantidade < this._maxTanque)
            {
                setTanque(quantidade);
                quant = quantidade;
            }
            return quant;
        }

        /// <summary>
        /// Metodo para calcular quanto que o tanque tem de combustivel
        /// </summary>
        /// <returns>Retorna o valor que está faltando</returns>
        public int CalcularTanque()
        {
            return (_tanque - this._maxTanque);
        }

        /// <summary>
        /// Liga/Desliga o carro
        /// </summary>
        public void ligarcarro()
        {
            if (_ligado == false) _ligado = true;
            else _ligado = false;
        }

        /// <summary>
        /// Dá a informação sobre o carro
        /// </summary>
        /// <returns></returns>
        public string Informação()
        {
            string ligado = "";
            if (_ligado == true) { ligado = "Ligado"; }
            if (_ligado == false) { ligado = "Desligado"; }

            return $"VEICULO\n\nNome do Carro: {_name}\nLigado: {ligado};\nTanque: {_tanque};\nMaximo Tanque: {_maxTanque};\nQuilometragem: {this._quilometragem};";
        }
    }
}
