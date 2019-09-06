using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_13___Veiculo
{
    class Etanol
    {
        //Atributos
        private int _consumo;

        //Construtor
        public Etanol()
        {
            this._consumo = 10;
        }

        //Metodos
        public int getConsumoCombustivel()
        {
            return this._consumo;
        }
    }
}
