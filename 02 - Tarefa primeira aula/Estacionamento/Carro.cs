using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento
{
    class Carro : Automovel
    {
        public Carro(int id, string tipo, int nPortas, string cor, string marca, string placa)
        {
            idAutomovel = id;
            Tipo = tipo;
            NumeroPortas = nPortas;
            Cor = cor;
            Marca = marca;
            Placa = placa;
        }

        public override string ToString()
        {
            
                return "\n-------------------------\nId: " + idAutomovel + "\nTipo: "+Tipo+"\nNumero de Portas: "+NumeroPortas+"\nCor: "+Cor+"\nMarca: "+Marca+"\nPlaca: "+Placa;
           
        }
    }
}
