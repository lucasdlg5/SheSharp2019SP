using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento
{
    class Program
    {
        static void Main(string[] args)
        {

            // Criando vagas estacionamento
            // ------------------------


            int qtd;
            Console.WriteLine("Digite a quantidade de vagas disponiveis, em seguida, a distinção das vagas.");
            qtd = int.Parse(Console.ReadLine());
            Estacionamento est1 = new Estacionamento(qtd);
            List<Automovel> listAutomovel = new List<Automovel>() ;
            
            // Entrada de carros e caracteristicas
            //--------------------

            int qtdIn = 0;

            Random rnd = new Random();
            int rndnumber = rnd.Next();

            Console.WriteLine("\n------------------\nIniciando o serviço de entrada de automoveis.\n------------------\n");
            Console.ReadKey();
            
            while (qtdIn < est1.getNumeroVagas())
            {

                //Console.WriteLine("Entrou While");
                
                switch (rnd.Next(1,4))
                {
                    case 1:
                        //Console.WriteLine("Entrou Case");
                        qtdIn++;

                        int idAutomovel = qtdIn;
                        Console.WriteLine("Está entrando uma Moto. Anote as caracteristicas!\nTipo: ");
                        string Tipo = Console.ReadLine();
                        Console.WriteLine("Numero de Portas: ");
                        int NumeroPortas = int.Parse(Console.ReadLine());
                        Console.WriteLine("Cor: ");
                        string Cor = Console.ReadLine();
                        Console.WriteLine("Marca: ");
                        string Marca = Console.ReadLine();
                        Console.WriteLine("Placa: ");
                        string Placa = Console.ReadLine();

                        listAutomovel.Add(new Carro(idAutomovel, Tipo, NumeroPortas, Cor, Marca, Placa));
            
                        break;

                    case 2:
                        qtdIn++;

                        break;

                    case 3:
                        qtdIn++;

                        break;

                    case 4:
                        qtdIn++;

                        break;

                    default:
                        Console.WriteLine("A");
                        break;
                }
            }

            Console.WriteLine(listAutomovel[0]);
            Console.ReadKey();
        }
    }
}
