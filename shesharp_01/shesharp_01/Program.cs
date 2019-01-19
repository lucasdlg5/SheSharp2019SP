using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shesharp_01
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Java é ruim");
            ContaCorrente contaCorrente = new ContaCorrente("Lusca", "123456789", "AGENCIA01", "999999999");
            Console.WriteLine("O nome do cliente é " + contaCorrente.Nome + " e o seu saldo é: "+ contaCorrente.Extrato().ToString());
            Console.WriteLine("Adicionando R$120,00");
            contaCorrente.Deposita(120.00M);
            Console.WriteLine("O Salto total agora é: " + contaCorrente.Extrato().ToString());
            Console.WriteLine("Retirando R$50,00");
            contaCorrente.Sacar(50.00M);
            Console.WriteLine("O Salto total agora é: " + contaCorrente.Extrato().ToString());
            Console.ReadKey();
        }

    }
}
