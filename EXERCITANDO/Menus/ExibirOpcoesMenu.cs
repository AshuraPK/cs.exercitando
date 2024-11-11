
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EXERCITANDO
{
    internal class ExibirMenu
    {

        public void ExibirOpcoesMenu()
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
                    // NOME DO ARQUIVO NOME DA VARIAVEL = NOVA FUNÇÃO
                    Ex1 variavelEx1 = new Ex1();
                    //VARIAVEL.NOVA FUNÇÃO
                    variavelEx1.atividade1();
                    break;


                case 2:
                    Ex2 variavelEx2 = new Ex2();
                    variavelEx2.atividade2();
                    break;

                case 3:
                    Ex3 variavelEx3 = new Ex3();
                    variavelEx3.atividade3();
                    break;

                case 4:
                    Ex4 variavelEx4 = new Ex4();
                    variavelEx4.atividade4();
                    break;

                case 5:
                    Ex5 variavelEx5 = new Ex5();
                    variavelEx5.atividade5();
                    break;

                case 6:
                    Ex6 variavelEx6 = new Ex6();
                    variavelEx6.atividade6();
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
                    
                    MenuInicial variavelCabecalho = new MenuInicial();
                    variavelCabecalho.ExibirCabecalho();

                    ExibirMenu variavelMenu = new ExibirMenu();
                    variavelMenu.ExibirOpcoesMenu();
                    break;

            }
        }
    }
}
