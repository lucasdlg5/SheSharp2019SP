using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shesharp_01
{
    class Conta
    {
        public string Nome { get; set; }
        public string Numero { get; set; }
        protected decimal Saldo { get; set; }
        public DateTime DataDeAbertura { get; set; }
        public string Agencia { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        private decimal LimiteDeChequeEspecial { get; set; }
    }
}
