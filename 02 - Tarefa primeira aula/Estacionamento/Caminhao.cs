using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento
{
    class Caminhao:Automovel
    {
        public Caminhao(int id, string tipo, int nPortas, string cor, string marca, string placa, int nJanela, Pessoa dono)
        {
            idAutomovel = id;
            Tipo = tipo;
            NumeroPortas = nPortas;
            Cor = cor;
            Marca = marca;
            Placa = placa;
            NumeroJanelas = nJanela;
            DonoCarro = dono;
        }

        public override string ToString()
        {

            return "\n-------------------------\nId: " + idAutomovel + "\nDono do Carro: " + DonoCarro + "\nTipo: " + Tipo + "\nNumero de Portas: " + NumeroPortas + "\nCor: " + Cor + "\nMarca: " + Marca + "\nPlaca: " + Placa + "\nNumero de Janelas: " + NumeroJanelas;

        }
    }
}
