using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento
{
    class Automovel
    {
        protected int idAutomovel {get; set;}
        protected string Tipo { get; set; }
        protected int NumeroPortas { get; set; }
        protected string Cor { get; set; }
        protected string Marca { get; set; }
        protected string Placa { get; set; }

        public override string ToString()
        {
            return "\n-------------------------\nId: " + idAutomovel + "\nTipo: " + Tipo + "\nNumero de Portas: " + NumeroPortas + "\nCor: " + Cor + "\nMarca: " + Marca + "\nPlaca: " + Placa;
        }
    }
}
