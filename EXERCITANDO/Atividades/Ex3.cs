using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EXERCITANDO
{
    internal class Ex3
    {
        public  void atividade3()
        {
            Console.Clear();
            Console.WriteLine("3. Escreva um programa que verifique se um número fornecido pelo usuário é par ou ímpar.");

            int imparPar = int.Parse(Console.ReadLine());

            if (imparPar % 2 == 0)
            {
                Console.WriteLine("O numero é par");
            }

            else
            {
                Console.WriteLine("O numero será impar");
            }

            Thread.Sleep(3000);
            Console.Clear();

            MenuInicial variavelCabecalho = new MenuInicial();
            variavelCabecalho.ExibirCabecalho();

            ExibirMenu variavelMenu = new ExibirMenu();
            variavelMenu.ExibirOpcoesMenu();

        }
    }
}
