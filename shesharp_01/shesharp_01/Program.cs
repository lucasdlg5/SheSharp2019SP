using System;

namespace shesharp_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Java é ruim");
            ContaCorrente contaCorrente = new ContaCorrente("Lusca", "123456789", "AGENCIA01", "999999999", 100.00M);
            contaCorrente.Deposita(50M);
            Console.WriteLine("O nome do cliente é " + contaCorrente.Nome + "\n - Saldo inicial é de: R$" + contaCorrente.getSaldo().ToString() + "\n - Cheque Especial de: " + contaCorrente.getLimiteDeChequeEspecial().ToString());
            //Console.WriteLine("O nome do cliente é " + contaCorrente.Nome);
            Console.WriteLine("\nInforme o valor que deseja Sacar");
            decimal valorASacar = Decimal.Parse(Console.ReadLine()); //Fara a conversão de tipo de dad sobre a leitura do que sera entrado no 
            contaCorrente.Sacar(valorASacar);
            Console.WriteLine("O Salto total agora é: " + contaCorrente.getSaldo().ToString());
            Console.ReadKey();
        }
    }
}
