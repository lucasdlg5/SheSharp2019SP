using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento
{
    class Estacionamento
    {
        private int NumeroVagas_Carro = 0;
        private int NumeroVagas_Moto = 0;
        private int NumeroVagas_Combi = 0;
        private int NumeroVagas_Caminhao = 0;
        private int NumeroTotal { get; set; }
        private int opt;


        public Estacionamento(int NumTot)
        {
            //NumeroTotal = NumTot;
            while (NumeroTotal != NumTot)
            {
                Console.WriteLine("Selecione a vaga que queira adicionar:\n1 - Carro\n2 - Moto\n3 - Combi\n4 - Caminhão");
                opt = int.Parse(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        Console.WriteLine("Quantas vagas disponiveis para: Carros");
                        NumeroVagas_Carro = int.Parse(Console.ReadLine());
                        if (!(NumeroVagas_Carro <= NumTot))
                        {
                            Console.WriteLine("Numero Acima do permitido!");
                        }
                        else
                        {
                            NumeroTotal += NumeroVagas_Carro;
                        }
                        
                        break;
                    case 2:
                        Console.WriteLine("Quantas vagas disponiveis para: Motos");
                        NumeroVagas_Moto = int.Parse(Console.ReadLine());
                        if (!(NumeroVagas_Moto <= NumTot))
                        {
                            Console.WriteLine("Numero Acima do permitido!");
                        }
                        else
                        {
                            NumeroTotal += NumeroVagas_Moto;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Quantas vagas disponiveis para: Combis");
                        NumeroVagas_Combi = int.Parse(Console.ReadLine());
                        if (!(NumeroVagas_Combi <= NumTot))
                        {
                            Console.WriteLine("Numero Acima do permitido!");
                        }
                        else
                        {
                            NumeroTotal += NumeroVagas_Combi;
                        }
                        break;
                    case 4:
                        Console.WriteLine("Quantas vagas disponiveis para: Caminhões");
                        NumeroVagas_Caminhao = int.Parse(Console.ReadLine());
                        if (!(NumeroVagas_Caminhao <= NumTot))
                        {
                            Console.WriteLine("Numero Acima do permitido!");
                        }
                        else
                        {
                            NumeroTotal += NumeroVagas_Caminhao;
                        }
                        break;
                    default:
                        Console.WriteLine("Numero invalido. O Numero de vagas disponiveis nao foi definida por completo.\nTermine de preencher.\n\n-------------------\n\n");
                        break;

                }

                if (NumeroTotal < NumTot)
                        Console.WriteLine("O Numero de vagas disponiveis nao foi definida por completo. ("+ NumeroTotal + "/"+ NumTot + ")\nTermine de preencher. \n\n-------------------\n\n");
                        //Console.ReadKey();
            }
            
            Console.WriteLine("\nVagas Disponiveis Totais: "+ NumeroTotal+"\nCarro: " + NumeroVagas_Carro + "\nMoto: "+ NumeroVagas_Moto + "\nCombi: "+ NumeroVagas_Combi + "\nCaminhão: "+NumeroVagas_Caminhao);
            //Console.ReadKey();
        }

        public void EntradaAutomovel()
        {

        }

        public void SaidaAutomovel()
        {

        }

        public string getInformacaoEstacionamento()
        {
            return "";
        }

        public int getNumeroVagas()
        {
            return NumeroTotal;
        }


        public int getNumeroVagasCarro()
        {
            return NumeroVagas_Carro;
        }

        public int getNumeroVagasMoto()
        {
            return NumeroVagas_Moto;
        }

        public int getNumeroVagasCombi()
        {
            return NumeroVagas_Combi;
        }

        public int getNumeroVagasCaminhao()
        {
            return NumeroVagas_Caminhao;
        }



    }

}
