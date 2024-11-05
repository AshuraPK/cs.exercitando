using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EXERCITANDO
{
    internal class ExibirOpcoesMenu
    {

        public static void ExibirOpcoesMenu()
        {
            Console.WriteLine("digite 1 para selecionar a atividade correspondente\n");
            Console.WriteLine("digite 2 para selecionar a atividade correspondente\n");
            Console.WriteLine("digite 3 para selecionar a atividade correspondente\n");
            Console.WriteLine("digite 4 para selecionar a atividade correspondente\n");
            Console.WriteLine("digite 5 para selecionar a atividade correspondente\n");
            Console.WriteLine("digite 6 para selecionar a atividade correspondente\n");
            Console.WriteLine("\ndigite a opção 0 para sair:");

            int opcaoEscolhidaNumero = int.Parse(Console.ReadLine());


            switch (opcaoEscolhidaNumero)
            {
                case 1:
                    Ex1();
                    break;


                case 2:
                    atividade2();
                    break;

                case 3:
                    atividade3();
                    break;

                case 4:
                    atividade4();
                    break;

                case 5:
                    atividade5();
                    break;

                case 6:
                    atividade6();
                    break;

                case 0:
                    Console.Clear();
                    Console.WriteLine(@"

░██████╗░█████╗░██╗███╗░░██╗██████╗░░█████╗░░░░░░░░░░
██╔════╝██╔══██╗██║████╗░██║██╔══██╗██╔══██╗░░░░░░░░░
╚█████╗░███████║██║██╔██╗██║██║░░██║██║░░██║░░░░░░░░░
░╚═══██╗██╔══██║██║██║╚████║██║░░██║██║░░██║░░░░░░░░░
██████╔╝██║░░██║██║██║░╚███║██████╔╝╚█████╔╝██╗██╗██╗
╚═════╝░╚═╝░░╚═╝╚═╝╚═╝░░╚══╝╚═════╝░░╚════╝░╚═╝╚═╝╚═╝");
                    Thread.Sleep(3000);
                    break;

                default:
                    Console.WriteLine("\n você digitou a opção invalida");
                    Thread.Sleep(3000);
                    ExibirCabecalho();
                    ExibirOpcoesMenu();
                    break;

            }
        }
