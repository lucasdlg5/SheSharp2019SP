using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shesharp_01
{
    class ContaCorrente : Conta
    {
        //Java é ruim primeiramente
        private decimal LimiteDeChequeEspecial { get; set; }

        //ctor e apertar TAB 2 vezes para criar o construtor automaticamente
        public ContaCorrente(string Nome, string Numero, string Agencia, string CPF)
        {
            this.Nome = Nome;
            this.Numero = Numero;
            this.Agencia = Agencia;
            this.CPF = CPF;
            //this.Telefone = Telefone;
            

        }

        public void Deposita(decimal valorDeposito)
        {
            //this.Saldo = this.Saldo + valorDeposito;
            this.Saldo += valorDeposito;
        }

        public void Sacar(decimal valorSaque)
        {
            if ((this.Saldo + LimiteDeChequeEspecial) >= valorSaque)
            {
                this.Saldo -= valorSaque;
            }//else
            //{
            //    this.Saldo -= valorSaque;
            //}
        }

        public decimal Extrato()
        {
            return this.Saldo;
        }

    }
}
