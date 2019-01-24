namespace shesharp_01
{
    class ContaPoupanca : Conta
    {
        public ContaPoupanca(string Nome, string Numero, string Agencia, string CPF)
        {
            this.Nome = Nome;
            this.Numero = Numero;
            this.Agencia = Agencia;
            this.CPF = CPF;
        }

        public ContaPoupanca() { }
    }
}
