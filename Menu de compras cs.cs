using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetin
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            int opcaocompra;
            double dinheiro = 900;

            do
            {
                Console.Clear();
                Console.WriteLine("MENU DE COMPRAS COUNTER STRIKE");
                Console.WriteLine("1-PISTOLAS");
                Console.WriteLine("2-PESADA");
                Console.WriteLine("3-SMG");
                Console.WriteLine("4-RIFLES");
                Console.WriteLine("5-EQUIPAMENTOS");
                Console.WriteLine("6-GRANADAS");
                Console.WriteLine("7-SAIR");

                opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.Clear();
                    Console.WriteLine("VOCE SELECIONOU MENU PISTOLA");
                    Console.WriteLine("1-USP---------------$200");
                    Console.WriteLine("2-P250--------------$250");
                    Console.WriteLine("3-CZ75--------------$500");
                    Console.WriteLine("4-Berettas----------$300");
                    Console.WriteLine("5-Five-Seven--------$500");
                    Console.WriteLine("6-Deagle------------$700");

                    opcaocompra = Convert.ToInt32(Console.ReadLine());

                    if (opcaocompra == 1)
                    {
                        if (dinheiro >= 200)
                        {
                            Console.WriteLine("VOCE ADQUIRIU UMA USP POR $200");
                            dinheiro = dinheiro - 200;
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("VOCE NÃO TEM DINHEIRO NECESSÁRIO PARA COMPRAR ESTE ITEM");
                            Console.ReadKey();
                        }


                    }

                    else if (opcaocompra == 2)
                    {
                        if (dinheiro >= 250)
                        {
                            Console.WriteLine("VOCE ADQUIRIU UMA P250 POR $250");
                            dinheiro = dinheiro - 250;
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("VOCE NÃO TEM DINHEIRO NECESSÁRIO PARA COMPRAR ESTE ITEM");
                            Console.ReadKey();
                        }

                    }

                    else if (opcaocompra == 3)
                    {
                        if (dinheiro >= 500)
                        {
                            Console.WriteLine("VOCE ADQUIRIU UMA CZ75 POR $500");
                            dinheiro = dinheiro - 500;
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("VOCE NÃO TEM DINHEIRO NECESSÁRIO PARA COMPRAR ESTE ITEM");
                            Console.ReadKey();
                        }

                    }

                    else if (opcaocompra == 4)
                    {
                        if (dinheiro >= 300)
                        {
                            Console.WriteLine("VOCE ADQUIRIU UMA Berettas POR $300");
                            dinheiro = dinheiro - 300;
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("VOCE NÃO TEM DINHEIRO NECESSÁRIO PARA COMPRAR ESTE ITEM");
                            Console.ReadKey();
                        }

                    }
                    else if (opcaocompra == 5)
                    {
                        if (dinheiro >= 500)
                        {
                            Console.WriteLine("VOCE ADQUIRIU UMA Five-Seven POR $500");
                            dinheiro = dinheiro - 500;
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("VOCE NÃO TEM DINHEIRO NECESSÁRIO PARA COMPRAR ESTE ITEM");
                            Console.ReadKey();
                        }

                    }

                    else if (opcaocompra == 6)
                    {
                        if (dinheiro >= 700)
                        {
                            Console.WriteLine("VOCE ADQUIRIU UMA Deagle POR $700");
                            dinheiro = dinheiro - 700;
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("VOCE NÃO TEM DINHEIRO NECESSÁRIO PARA COMPRAR ESTE ITEM");
                            Console.ReadKey();
                        }

                    }
                    Console.ReadKey();
                }

                else if (opcao == 2)
                {
                    Console.Clear();
                    Console.WriteLine("VOCE SELECIONOU MENU DE ARMAS PESADAS");
                    Console.ReadKey();

                    if (opcao == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("VOCE SELECIONOU MENU ARMAS PESADAS");
                        Console.WriteLine("1-Nova-------------------$1200");
                        Console.WriteLine("2-Sawed-Off--------------$1200");
                        Console.WriteLine("3-MAG-7------------------$1800");
                        Console.WriteLine("4-XM1014-----------------$2200");
                        Console.WriteLine("5-M249-------------------$5200");
                        Console.WriteLine("6-Negev------------------$1700");

                        opcaocompra = Convert.ToInt32(Console.ReadLine());

                        if (opcaocompra == 1)
                        {
                            if (dinheiro >= 1200)
                            {
                                Console.WriteLine("VOCE ADQUIRIU UMA NOVA POR $1200");
                                dinheiro = dinheiro - 1200;
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("VOCE NÃO TEM DINHEIRO NECESSÁRIO PARA COMPRAR ESTE ITEM");
                                Console.ReadKey();
                            }


                        }

                        else if (opcaocompra == 2)
                        {
                            if (dinheiro >= 1200)
                            {
                                Console.WriteLine("VOCE ADQUIRIU UMA SAWED-OFF POR $1200");
                                dinheiro = dinheiro - 1200;
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("VOCE NÃO TEM DINHEIRO NECESSÁRIO PARA COMPRAR ESTE ITEM");
                                Console.ReadKey();
                            }

                        }

                        else if (opcaocompra == 3)
                        {
                            if (dinheiro >= 1800)
                            {
                                Console.WriteLine("VOCE ADQUIRIU UMA MAG-7 POR $1800");
                                dinheiro = dinheiro - 1800;
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("VOCE NÃO TEM DINHEIRO NECESSÁRIO PARA COMPRAR ESTE ITEM");
                                Console.ReadKey();
                            }

                        }

                        else if (opcaocompra == 4)
                        {
                            if (dinheiro >= 2200)
                            {
                                Console.WriteLine("VOCE ADQUIRIU UMA XM1014 POR $2200");
                                dinheiro = dinheiro - 2200;
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("VOCE NÃO TEM DINHEIRO NECESSÁRIO PARA COMPRAR ESTE ITEM");
                                Console.ReadKey();
                            }

                        }
                        else if (opcaocompra == 5)
                        {
                            if (dinheiro >= 5200)
                            {
                                Console.WriteLine("VOCE ADQUIRIU UMA M249 POR $5200");
                                dinheiro = dinheiro - 5200;
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("VOCE NÃO TEM DINHEIRO NECESSÁRIO PARA COMPRAR ESTE ITEM");
                                Console.ReadKey();
                            }

                        }

                        else if (opcaocompra == 6)
                        {
                            if (dinheiro >= 1700)
                            {
                                Console.WriteLine("VOCE ADQUIRIU UMA NEGEV POR $1700");
                                dinheiro = dinheiro - 1700;
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("VOCE NÃO TEM DINHEIRO NECESSÁRIO PARA COMPRAR ESTE ITEM");
                                Console.ReadKey();
                            }

                        }
                        Console.ReadKey();
                    }
                }

                else if (opcao == 3)
                {
                    Console.Clear();
                    Console.WriteLine("VOCE SELECIONOU MENU DE SMG");
                    Console.ReadKey();

                    if (opcao == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("VOCE SELECIONOU MENU SMG");
                        Console.WriteLine("1-MAC-10---------------$1050");
                        Console.WriteLine("2-UMP------------------$1200");
                        Console.WriteLine("3-MP9------------------$1250");
                        Console.WriteLine("4-Bizon----------------$1400");
                        Console.WriteLine("5-MP5------------------$1500");
                        Console.WriteLine("6-MP7------------------$1500");

                        opcaocompra = Convert.ToInt32(Console.ReadLine());

                        if (opcaocompra == 1)
                        {
                            if (dinheiro >= 1050)
                            {
                                Console.WriteLine("VOCE ADQUIRIU UMA MAC-10 POR $1050");
                                dinheiro = dinheiro - 1050;
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("VOCE NÃO TEM DINHEIRO NECESSÁRIO PARA COMPRAR ESTE ITEM");
                                Console.ReadKey();
                            }


                        }

                        else if (opcaocompra == 2)
                        {
                            if (dinheiro >= 1200)
                            {
                                Console.WriteLine("VOCE ADQUIRIU UMA UMP POR $1200");
                                dinheiro = dinheiro - 1200;
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("VOCE NÃO TEM DINHEIRO NECESSÁRIO PARA COMPRAR ESTE ITEM");
                                Console.ReadKey();
                            }

                        }

                        else if (opcaocompra == 3)
                        {
                            if (dinheiro >= 1250)
                            {
                                Console.WriteLine("VOCE ADQUIRIU UMA MP9 POR $1250");
                                dinheiro = dinheiro - 1250;
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("VOCE NÃO TEM DINHEIRO NECESSÁRIO PARA COMPRAR ESTE ITEM");
                                Console.ReadKey();
                            }

                        }

                        else if (opcaocompra == 4)
                        {
                            if (dinheiro >= 1400)
                            {
                                Console.WriteLine("VOCE ADQUIRIU UMA BIZON POR $1400");
                                dinheiro = dinheiro - 1400;
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("VOCE NÃO TEM DINHEIRO NECESSÁRIO PARA COMPRAR ESTE ITEM");
                                Console.ReadKey();
                            }

                        }
                        else if (opcaocompra == 5)
                        {
                            if (dinheiro >= 1500)
                            {
                                Console.WriteLine("VOCE ADQUIRIU UMA MP5 POR $1500");
                                dinheiro = dinheiro - 1500;
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("VOCE NÃO TEM DINHEIRO NECESSÁRIO PARA COMPRAR ESTE ITEM");
                                Console.ReadKey();
                            }

                        }

                        else if (opcaocompra == 6)
                        {
                            if (dinheiro >= 1500)
                            {
                                Console.WriteLine("VOCE ADQUIRIU UMA MP7 POR $1500");
                                dinheiro = dinheiro - 1500;
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("VOCE NÃO TEM DINHEIRO NECESSÁRIO PARA COMPRAR ESTE ITEM");
                                Console.ReadKey();
                            }

                        }
                        Console.ReadKey();
                    }
                }

                else if (opcao == 4)
                {
                    Console.Clear();
                    Console.WriteLine("VOCE SELECIONOU MENU DE REFLES");
                    Console.ReadKey();


                    if (opcao == 4)
                    {
                        Console.Clear();
                        Console.WriteLine("VOCE SELECIONOU MENU REFLES");
                        Console.WriteLine("1-SSG---------------$1700	");
                        Console.WriteLine("2-Galil------------------$1800	");
                        Console.WriteLine("3-FAMAS------------------$2050");
                        Console.WriteLine("4-AK-47----------------$2700");
                        Console.WriteLine("5-SG	------------------$3000");
                        Console.WriteLine("6-M4A4------------------$3100	");


                        opcaocompra = Convert.ToInt32(Console.ReadLine());

                        if (opcaocompra == 1)
                        {
                            if (dinheiro >= 1700)
                            {
                                Console.WriteLine("VOCE ADQUIRIU UMA SSG POR $1700");
                                dinheiro = dinheiro - 1700;
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("VOCE NÃO TEM DINHEIRO NECESSÁRIO PARA COMPRAR ESTE ITEM");
                                Console.ReadKey();
                            }


                        }

                        else if (opcaocompra == 2)
                        {
                            if (dinheiro >= 1800)
                            {
                                Console.WriteLine("VOCE ADQUIRIU UMA Galil POR $1800");
                                dinheiro = dinheiro - 1800;
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("VOCE NÃO TEM DINHEIRO NECESSÁRIO PARA COMPRAR ESTE ITEM");
                                Console.ReadKey();
                            }

                        }

                        else if (opcaocompra == 3)
                        {
                            if (dinheiro >= 2050)
                            {
                                Console.WriteLine("VOCE ADQUIRIU UMA FAMAS POR $2050");
                                dinheiro = dinheiro - 2050;
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("VOCE NÃO TEM DINHEIRO NECESSÁRIO PARA COMPRAR ESTE ITEM");
                                Console.ReadKey();
                            }

                        }

                        else if (opcaocompra == 4)
                        {
                            if (dinheiro >= 2700)
                            {
                                Console.WriteLine("VOCE ADQUIRIU UMA AK-47 POR $2700");
                                dinheiro = dinheiro - 2700;
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("VOCE NÃO TEM DINHEIRO NECESSÁRIO PARA COMPRAR ESTE ITEM");
                                Console.ReadKey();
                            }

                        }
                        else if (opcaocompra == 5)
                        {
                            if (dinheiro >= 3000)
                            {
                                Console.WriteLine("VOCE ADQUIRIU UMA SG POR $3000");
                                dinheiro = dinheiro - 3000;
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("VOCE NÃO TEM DINHEIRO NECESSÁRIO PARA COMPRAR ESTE ITEM");
                                Console.ReadKey();
                            }

                        }

                        else if (opcaocompra == 6)
                        {
                            if (dinheiro >= 3100)
                            {
                                Console.WriteLine("VOCE ADQUIRIU UMA MM4A4 POR $3100");
                                dinheiro = dinheiro - 3100;
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("VOCE NÃO TEM DINHEIRO NECESSÁRIO PARA COMPRAR ESTE ITEM");
                                Console.ReadKey();
                            }

                        }
                        Console.ReadKey();
                    }
                }

                else if (opcao == 5)
                {
                    Console.Clear();
                    Console.WriteLine("VOCE SELECIONOU MENU DE EQUIPAMENTOS");
                    Console.ReadKey();

                    if (opcao == 5)
                    {
                        Console.Clear();
                        Console.WriteLine("VOCE SELECIONOU MENU EQUIPAMENTOS");
                        Console.WriteLine("1-COLETE---------------$650");
                        Console.WriteLine("2-CAPACETE------------------$1400");
                        Console.WriteLine("3-CURA------------------$400");
                        Console.ReadKey();


                        opcaocompra = Convert.ToInt32(Console.ReadLine());

                        if (opcaocompra == 1)
                        {
                            if (dinheiro >= 650)
                            {
                                Console.WriteLine("VOCE ADQUIRIU UM COLETE POR $650");
                                dinheiro = dinheiro - 650;
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("VOCE NÃO TEM DINHEIRO NECESSÁRIO PARA COMPRAR ESTE ITEM");
                                Console.ReadKey();
                            }


                        }

                        else if (opcaocompra == 2)
                        {
                            if (dinheiro >= 1400)
                            {
                                Console.WriteLine("VOCE ADQUIRIU UM CAPACETE POR $1400");
                                dinheiro = dinheiro - 1400;
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("VOCE NÃO TEM DINHEIRO NECESSÁRIO PARA COMPRAR ESTE ITEM");
                                Console.ReadKey();
                            }

                        }

                        else if (opcaocompra == 3)
                        {
                            if (dinheiro >= 400)
                            {
                                Console.WriteLine("VOCE ADQUIRIU UMA CURA POR $400");
                                dinheiro = dinheiro - 400;
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("VOCE NÃO TEM DINHEIRO NECESSÁRIO PARA COMPRAR ESTE ITEM");
                                Console.ReadKey();
                            }

                        }

                        Console.ReadKey();
                    }
                }

                else if (opcao == 6)
                {
                    Console.Clear();
                    Console.WriteLine("VOCE SELECIONOU MENU DE GRANADAS");
                    Console.ReadKey();


                    if (opcao == 6)
                    {

                        Console.WriteLine("VOCE SELECIONOU MENU GRANADAS");
                        Console.WriteLine("1-Flashbang---------------$200");
                        Console.WriteLine("2-Smoke------------------$300");
                        Console.WriteLine("3-HE------------------$300");
                        Console.WriteLine("4-Molotov----------------$400");
                        Console.WriteLine("5-Incendiária-----------------$600");



                        opcaocompra = Convert.ToInt32(Console.ReadLine());

                        if (opcaocompra == 1)
                        {
                            if (dinheiro >= 200)
                            {
                                Console.WriteLine("VOCE ADQUIRIU UM FLASHBANG POR $200");
                                dinheiro = dinheiro - 200;
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("VOCE NÃO TEM DINHEIRO NECESSÁRIO PARA COMPRAR ESTE ITEM");
                                Console.ReadKey();
                            }


                        }

                        else if (opcaocompra == 2)
                        {
                            if (dinheiro >= 300)
                            {
                                Console.WriteLine("VOCE ADQUIRIU UMA SMOKE POR $300");
                                dinheiro = dinheiro - 300;
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("VOCE NÃO TEM DINHEIRO NECESSÁRIO PARA COMPRAR ESTE ITEM");
                                Console.ReadKey();
                            }

                        }

                        else if (opcaocompra == 3)
                        {
                            if (dinheiro >= 300)
                            {
                                Console.WriteLine("VOCE ADQUIRIU UMA HE POR $300");
                                dinheiro = dinheiro - 300;
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("VOCE NÃO TEM DINHEIRO NECESSÁRIO PARA COMPRAR ESTE ITEM");
                                Console.ReadKey();
                            }

                        }

                        else if (opcaocompra == 4)
                        {
                            if (dinheiro >= 400)
                            {
                                Console.WriteLine("VOCE ADQUIRIU UMA MOLOTOV POR $400");
                                dinheiro = dinheiro - 400;
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("VOCE NÃO TEM DINHEIRO NECESSÁRIO PARA COMPRAR ESTE ITEM");
                                Console.ReadKey();
                            }

                        }
                        else if (opcaocompra == 5)
                        {
                            if (dinheiro >= 600)
                            {
                                Console.WriteLine("VOCE ADQUIRIU UMA INCENDIÁRIA POR 600");
                                dinheiro = dinheiro - 600;
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("VOCE NÃO TEM DINHEIRO NECESSÁRIO PARA COMPRAR ESTE ITEM");
                                Console.ReadKey();
                            }

                        }

                        Console.ReadKey();
                    }
                }

                else if (opcao == 7)
                {
                    Console.Clear();
                    Console.WriteLine("VOCE SAIU DO MENU DE COMPRAS");
                    Console.ReadKey();
                }

            } while (opcao != 7);


            Console.ReadKey();


        }
    }
}
