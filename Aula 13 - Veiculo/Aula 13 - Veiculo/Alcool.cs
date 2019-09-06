using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_13___Veiculo
{
    class Alcool
    {
        //Atributos
        private int _consumo;

        //Construtor
        public Alcool()
        {
            this._consumo = 7;
        }

        //Metodos
        public int getConsumoCombustivel()
        {
            return this._consumo;
        }
    }
}
