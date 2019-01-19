using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shesharp_01
{
    class ContaPoupanca : Conta
    {
 


        public void Deposita(decimal valorDeposito)
        {
            //this.Saldo = this.Saldo + valorDeposito;
            this.Saldo += valorDeposito;
        }

        public void Sacar(decimal valorSaque)
        {
            if (this.Saldo >= valorSaque)
            {
                this.Saldo -= valorSaque;
            }
            //else
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
