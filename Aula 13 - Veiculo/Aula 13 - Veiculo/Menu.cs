using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Aula_13___Veiculo
{
    class Menu
    {   
        //Metodos

        /// <summary>
        /// Demonstra o menu principal.
        /// </summary>
        public void menuPrincipal()
        {
            bool loop = true;
            do
            {
                Console.Clear();
                Console.WriteLine("MENU.\n");
                Console.WriteLine("1 - Adicionar veiculo.");
                Console.WriteLine("0 - Sair.\n\n");
                Console.Write("Opção: ");
                char key = Console.ReadKey().KeyChar;

                switch (key)
                {
                    case '1':
                        Console.Clear();
                        Console.WriteLine("Adicionar veiculo\n");
                        Console.WriteLine("Digite o nome do veiculo.");
                        Console.Write("Nome: ");
                        string name = Console.ReadLine();

                        Console.WriteLine("\n\nEscolha o Tipo do combustivel.\n");
                        Console.WriteLine("1 - Etanol(Gasolina).");
                        Console.WriteLine("2 - Alcool.\n");
                        Console.Write("Opção: ");
                        char key2 = Console.ReadKey().KeyChar;

                        switch (key2)
                        {
                            case '1':
                                Console.WriteLine("\n\nDigite o tamanho do tanque.\n");
                                Console.WriteLine("1 - tanque com 40 litros");
                                Console.WriteLine("2 - tanque com 50 litros\n");
                                Console.Write("Opção: ");
                                char key3 = Console.ReadKey().KeyChar;
                                switch (key3)
                                {
                                    case '1':
                                        Veiculo veic = new Veiculo(name, 2, 1);
                                        bool loop2 = true;
                                        do
                                        {
                                            Console.Clear();
                                            Console.WriteLine(veic.Informação());
                                            Console.WriteLine("\nMenu");
                                            Console.WriteLine("\n\n1 - ligar/Desligar carro." +
                                                "\n2 - Percorrer 1Km." +
                                                "\n3 - Reabastecer." +
                                                "\n0 - Sair\n");
                                            Console.Write("Opção: ");
                                            char opcao = Console.ReadKey().KeyChar;
                                            switch (opcao)
                                            {
                                                case '1':
                                                    veic.ligarcarro();
                                                    break;
                                                case '2':
                                                    if (veic.addquilometragemTipoComb())
                                                    {
                                                        Console.WriteLine("\n\nVocê percorreu 1 Km.");
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("\n\nCarro desligado.");
                                                    }
                                                    break;
                                                case '3':
                                                    Console.WriteLine($"\n\nCarro reabastecido na quantidade de: {veic.reabastecer(50)}.");
                                                    Thread.Sleep(1000);
                                                    break;
                                                case '0':
                                                    loop = false;
                                                    loop2 = false;
                                                    break;
                                                default:
                                                    Console.WriteLine("\n\nTecla incorreta, voltarar ao menu principal.");
                                                    Thread.Sleep(1500);
                                                    break;
                                            }
                                        } while (loop2);

                                        break;
                                    case '2':
                                        Veiculo veic2 = new Veiculo(name, 2, 2);
                                        bool loop3 = true;
                                        do
                                        {
                                            Console.Clear();
                                            Console.WriteLine(veic2.Informação());
                                            Console.WriteLine("\nMenu");
                                            Console.WriteLine("\n\n1 - ligar/Desligar carro." +
                                                "\n2 - Percorrer 1Km." +
                                                "\n3 - Reabastecer." +
                                                "\n0 - Sair\n");
                                            Console.Write("Opção: ");
                                            char opcao = Console.ReadKey().KeyChar;
                                            switch (opcao)
                                            {
                                                case '1':
                                                    veic2.ligarcarro();
                                                    break;
                                                case '2':
                                                    if (veic2.addquilometragemTipoComb())
                                                    {
                                                        Console.WriteLine("\n\nVocê percorreu 1 Km.");
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("\n\nCarro desligado.");
                                                    }
                                                    break;
                                                case '3':
                                                    Console.WriteLine($"\n\nCarro reabastecido na quantidade de: {veic2.reabastecer(50)}.");
                                                    Thread.Sleep(1000);
                                                    break;
                                                case '0':
                                                    loop = false;
                                                    loop3 = false;
                                                    break;
                                                default:
                                                    break;
                                            }
                                        } while (loop3);
                                        break;
                                    default:
                                        Console.WriteLine("\n\nTecla incorreta, voltarar ao menu principal.");
                                        Thread.Sleep(1500);
                                        break;
                                }

                                break;
                            case '2':
                                Console.WriteLine("\n\nDigite o tamanho do tanque.\n");
                                Console.WriteLine("1 - tanque com 40 litros");
                                Console.WriteLine("2 - tanque com 50 litros\n");
                                Console.Write("Opção: ");
                                char key4 = Console.ReadKey().KeyChar;
                                switch (key4)
                                {
                                    case '1':
                                        Veiculo veic3 = new Veiculo(name, 1, 1);
                                        bool loop4 = true;
                                        do
                                        {
                                            Console.Clear();
                                            Console.WriteLine(veic3.Informação());
                                            Console.WriteLine("\nMenu");
                                            Console.WriteLine("\n\n1 - ligar/Desligar carro." +
                                                "\n2 - Percorrer 1Km." +
                                                "\n3 - Reabastecer." +
                                                "\n0 - Sair\n");
                                            Console.Write("Opção: ");
                                            char opcao = Console.ReadKey().KeyChar;
                                            switch (opcao)
                                            {
                                                case '1':
                                                    veic3.ligarcarro();
                                                    break;
                                                case '2':
                                                    if (veic3.addquilometragemTipoComb())
                                                    {
                                                        Console.WriteLine("\n\nVocê percorreu 1 Km.");
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("\n\nCarro desligado.");
                                                    }
                                                    break;
                                                case '3':
                                                    Console.WriteLine($"\n\nCarro reabastecido na quantidade de: {veic3.reabastecer(50)}.");
                                                    Thread.Sleep(1000);
                                                    break;
                                                case '0':
                                                    loop = false;
                                                    loop4 = false;
                                                    break;
                                                default:
                                                    Console.WriteLine("\n\nTecla incorreta, voltarar ao menu principal.");
                                                    Thread.Sleep(1500);
                                                    break;
                                            }
                                        } while (loop4);

                                        break;
                                    case '2':
                                        Veiculo veic4 = new Veiculo(name, 1, 2);
                                        bool loop5 = true;
                                        do
                                        {
                                            Console.Clear();
                                            Console.WriteLine(veic4.Informação());
                                            Console.WriteLine("\nMenu");
                                            Console.WriteLine("\n\n1 - ligar/Desligar carro." +
                                                "\n2 - Percorrer 1Km." +
                                                "\n3 - Reabastecer." +
                                                "\n0 - Sair\n");
                                            Console.Write("Opção: ");
                                            char opcao = Console.ReadKey().KeyChar;
                                            switch (opcao)
                                            {
                                                case '1':
                                                    veic4.ligarcarro();
                                                    break;
                                                case '2':
                                                    if (veic4.addquilometragemTipoComb())
                                                    {
                                                        Console.WriteLine("\n\nVocê percorreu 1 Km.");
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("\n\nCarro desligado.");
                                                    }
                                                    break;
                                                case '3':
                                                    Console.WriteLine($"\n\nCarro reabastecido na quantidade de: {veic4.reabastecer(50)}.");
                                                    Thread.Sleep(1000);
                                                    break;
                                                case '0':
                                                    loop = false;
                                                    loop5 = false;
                                                    break;
                                                default:
                                                    Console.WriteLine("\n\nTecla incorreta, voltarar ao menu principal.");
                                                    Thread.Sleep(1500);
                                                    break;
                                            }
                                        } while (loop5);
                                        break;
                                    default:
                                        Console.WriteLine("\n\nTecla incorreta, voltarar ao menu principal.");
                                        Thread.Sleep(1500);
                                        break;
                                }
                                break;
                            default:
                                Console.WriteLine("\n\nTecla incorreta, voltarar ao menu principal.");
                                Thread.Sleep(1500);
                                break;
                        }

                        Console.WriteLine("\n");
                        break;
                    case '0':
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("\n\nTecla incorreta, voltarar ao menu principal.");
                        Thread.Sleep(2000);
                        break;
                }

            } while (loop);
        }
    }
}
