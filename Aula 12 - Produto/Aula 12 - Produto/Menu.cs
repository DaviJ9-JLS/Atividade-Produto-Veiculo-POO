using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aula_12___Produto
{
    class Menu
    {
        private Estoque estoque;


        public Menu()
        {
            this.estoque = new Estoque();
            this.estoque.addProduto("Macarrao", "Macarrao com queijão, carne muida, molho de tomate e mangericão.", 10.0, "Comida");
            this.estoque.addProduto("Coca-Cola", "Bebida com gás", 5.0, "Bebida");
            this.estoque.addProduto("Vassora", "Material que serve para varrer as inpurezas", 18.0, "Material");
        }

        public void menuPrincipal()
        {
            bool loop = true;
            do
            {
                Console.Clear();
                Console.WriteLine("MENU");
                Console.WriteLine("\n1 - Adicionar produto" +
                    "\n2 - informação" +
                    "\n3 - Vender produtor" +
                    "\n0 - Sair\n");
                int aux = 0;
                Console.Write("Opção: ");
                char key = Console.ReadKey().KeyChar;
                switch (key)
                {
                    case '1':
                        string auxString1 = "";
                        string auxString2 = "";
                        double auxDouble = 0.0;
                        string auxString4 = "";

                        Console.WriteLine("\n\nDigite o Nome do produto, a Descrição, o Preço e a categoria");

                        Console.WriteLine("\nDigite o nome:");
                        auxString1 = Console.ReadLine();
                        Console.WriteLine("\nDigite Uma descrição:");
                        auxString2 = Console.ReadLine();
                        Console.WriteLine("\nDigite o Preco:");

                        try
                        {
                            auxDouble = Convert.ToDouble(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("\nValor incorreto, o Preco foi para 10");
                            auxDouble = 10.0;
                        }

                        Console.WriteLine("\nQual categoria?" +
                            "\n1 - Comida" +
                            "\n2 - Bebida" +
                            "\n3 - Material de limpeza\n");
                        Console.Write("Opção: ");
                        char key2 = Console.ReadKey().KeyChar;
                        string categoria = "";
                        switch (key2)
                        {
                            case '1':
                                estoque.addProduto(auxString1, auxString2, auxDouble, "Comida");
                                break;
                            case '2':
                                estoque.addProduto(auxString1, auxString2, auxDouble, "Bebida");
                                break;
                            case '3':
                                estoque.addProduto(auxString1, auxString2, auxDouble, "Material");
                                break;
                            default:
                                Console.WriteLine("\nTecla invalida");
                                break;
                        }
                        break;
                    case '2':
                        Console.WriteLine(estoque.informacao());
                        Console.WriteLine("\nClique em alguma tecla para sair");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case '3':
                        bool certo = true;
                        do
                        {
                            Console.WriteLine();
                            Console.WriteLine(estoque.getIdEName());
                            Console.WriteLine("Digite exatamente o nome que deseja");
                            string name = Console.ReadLine();
                            for (int i = 0; i < estoque.getTamanhoProds(); i++)
                            {
                                if (estoque.Pesquisar(name))
                                {
                                    estoque.venderProd(name);
                                    i += estoque.getTamanhoProds();
                                }
                            }

                            Console.WriteLine("\nDeseja comprar mais? ");
                            Console.WriteLine("1 - Sim");
                            Console.WriteLine("2 - Não\n\n");
                            Console.Write("Opção: ");
                            char key3 = Console.ReadKey().KeyChar;
                            switch (key3)
                            {
                                case '1':
                                    certo = true;
                                    break;
                                case '2':
                                    certo = false;
                                    break;
                                default:
                                    Console.WriteLine("\n\nTecla errada.");
                                    Thread.Sleep(1000);
                                    certo = false;
                                    break;
                            }

                        } while (certo);
                        break;
                    case '0':
                        loop = false;
                        break;
                    default:
                        break;
                }
            } while (loop);
        }
    }
}
