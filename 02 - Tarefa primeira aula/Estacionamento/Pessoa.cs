using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento
{
    class Pessoa
    {
        protected string nomePessoa { get; set; }
        protected string RG { get; set; }

        public Pessoa (string nomeDono, string rgDono)
        {
            nomePessoa = nomeDono;
            RG = rgDono;
        }

    }

}
