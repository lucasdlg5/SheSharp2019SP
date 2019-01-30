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


            List<Automovel> listAutomovel = new List<Automovel>() ;

            // Criando vagas estacionamento
            // ------------------------

            Console.WriteLine("Digite a quantidade de vagas disponiveis, em seguida, a distinção das vagas.");
            int qtd;
            qtd = int.Parse(Console.ReadLine());

            Estacionamento est1 = new Estacionamento(qtd);
            
            // Entrada de carros e caracteristicas
            //--------------------

            int qtdIn = 0;

            Random rnd = new Random();
            int rndnumber = rnd.Next();

            Console.WriteLine("\n------------------\nIniciando o serviço de entrada de automoveis.\n------------------\n");
            Console.ReadKey();
            
            int idAutomovel = 0;
            string Tipo = "";
            int NumeroPortas = 0;
            string Cor = "";
            string Marca = "";
            string Placa = "";
            int nJanelas = 0;
            string nomeDono = "";
            string rgDono = "";

            

            while (qtdIn < est1.getNumeroVagas())
            {

                switch (rnd.Next(1,4))
                {
                    case 1:
                        if (est1.getNumeroVagasCarro() == 0)
                        {
                            Console.WriteLine("Não Há vagas disponiveis para Carro!");
                            break;
                        }else
                        {

                            qtdIn++;

                            Console.WriteLine("\n---Está entrando um CARRO---\n");

                            idAutomovel = qtdIn;
                            Console.WriteLine("Anote as caracteristicas!\nTipo: ");
                            Tipo = Console.ReadLine();
                            Console.WriteLine("Numero de Portas: ");
                            NumeroPortas = int.Parse(Console.ReadLine());
                            Console.WriteLine("Cor: ");
                            Cor = Console.ReadLine();
                            Console.WriteLine("Marca: ");
                            Marca = Console.ReadLine();
                            Console.WriteLine("Placa: ");
                            Placa = Console.ReadLine();
                            Console.WriteLine("Numero de Janelas: ");
                            nJanelas = int.Parse(Console.ReadLine());
                            Console.WriteLine("Nome do Dono Automovel: ");
                            nomeDono = Console.ReadLine();
                            Console.WriteLine("Rg do Dono do Automovel: ");
                            rgDono = Console.ReadLine();
                            listAutomovel.Add(new Carro(idAutomovel, Tipo, NumeroPortas, Cor, Marca, Placa, nJanelas, new Pessoa(nomeDono, rgDono)));
            
                            break;
                        }


                    case 2:
                        if (est1.getNumeroVagasMoto() == 0)
                        {
                            Console.WriteLine("Não Há vagas disponiveis para Moto!");
                            break;
                        }else
                        {

                            qtdIn++;

                            Console.WriteLine("\n---Está entrando uma MOTO---\n");

                            idAutomovel = qtdIn;
                            Console.WriteLine("Anote as caracteristicas!\nTipo: ");
                            Tipo = Console.ReadLine();
                            Console.WriteLine("Numero de Portas: ");
                            NumeroPortas = int.Parse(Console.ReadLine());
                            Console.WriteLine("Cor: ");
                            Cor = Console.ReadLine();
                            Console.WriteLine("Marca: ");
                            Marca = Console.ReadLine();
                            Console.WriteLine("Placa: ");
                            Placa = Console.ReadLine();
                            Console.WriteLine("Numero de Janelas: ");
                            nJanelas = int.Parse(Console.ReadLine());
                            Console.WriteLine("Nome do Dono Automovel: ");
                            nomeDono = Console.ReadLine();
                            Console.WriteLine("Rg do Dono do Automovel: ");
                            rgDono = Console.ReadLine();

                            listAutomovel.Add(new Moto(idAutomovel, Tipo, NumeroPortas, Cor, Marca, Placa, nJanelas, new Pessoa(nomeDono, rgDono)));

                            break;
                        }

                    case 3:
                        if (est1.getNumeroVagasCombi() == 0)
                        {
                            Console.WriteLine("Não Há vagas disponiveis para Combi!");
                            break;
                        }else
                        {

                            qtdIn++;

                            Console.WriteLine("\n---Está entrando uma Combi---\n");

                            idAutomovel = qtdIn;
                            Console.WriteLine("Anote as caracteristicas!\nTipo: ");
                            Tipo = Console.ReadLine();
                            Console.WriteLine("Numero de Portas: ");
                            NumeroPortas = int.Parse(Console.ReadLine());
                            Console.WriteLine("Cor: ");
                            Cor = Console.ReadLine();
                            Console.WriteLine("Marca: ");
                            Marca = Console.ReadLine();
                            Console.WriteLine("Placa: ");
                            Placa = Console.ReadLine();
                            Console.WriteLine("Numero de Janelas: ");
                            nJanelas = int.Parse(Console.ReadLine());
                            Console.WriteLine("Nome do Dono Automovel: ");
                            nomeDono = Console.ReadLine();
                            Console.WriteLine("Rg do Dono do Automovel: ");
                            rgDono = Console.ReadLine();
                            listAutomovel.Add(new Combi(idAutomovel, Tipo, NumeroPortas, Cor, Marca, Placa, nJanelas, new Pessoa(nomeDono, rgDono)));

                            break;
                        }

                    case 4:
                        if (est1.getNumeroVagasCaminhao() == 0)
                        {
                            Console.WriteLine("Não Há vagas disponiveis para Caminhão!");
                            break;
                        }else
                        {

                            qtdIn++;

                            Console.WriteLine("\n---Está entrando um CAMINHAO---\n");

                            idAutomovel = qtdIn;
                            Console.WriteLine("Anote as caracteristicas!\nTipo: ");
                            Tipo = Console.ReadLine();
                            Console.WriteLine("Numero de Portas: ");
                            NumeroPortas = int.Parse(Console.ReadLine());
                            Console.WriteLine("Cor: ");
                            Cor = Console.ReadLine();
                            Console.WriteLine("Marca: ");
                            Marca = Console.ReadLine();
                            Console.WriteLine("Placa: ");
                            Placa = Console.ReadLine();
                            Console.WriteLine("Numero de Janelas: ");
                            nJanelas = int.Parse(Console.ReadLine());
                            Console.WriteLine("Nome do Dono Automovel: ");
                            nomeDono = Console.ReadLine();
                            Console.WriteLine("Rg do Dono do Automovel: ");
                            rgDono = Console.ReadLine();
                            listAutomovel.Add(new Caminhao(idAutomovel, Tipo, NumeroPortas, Cor, Marca, Placa, nJanelas, new Pessoa(nomeDono, rgDono)));

                            break;
                        }

                    default:
                        Console.WriteLine("\n\nDEFAULT\n\n\n");
                        break;
                }
            }

            Console.WriteLine(listAutomovel[0]);
            Console.ReadKey();
        }
    }
}
