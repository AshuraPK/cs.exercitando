using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EXERCITANDO
{
    internal class Ex2
    {

        public void atividade2()
        {
            Console.Clear();
            Console.WriteLine("2. Crie um programa que leia a idade de uma pessoa e informe se ela é maior de idade (18 anos ou mais) ou menor de idade.");

            int id = int.Parse(Console.ReadLine());

            if (id >= 18)
            {
                Console.WriteLine("você é maior de idade!");
            }
            else if (id < 18)
            {
                Console.WriteLine("você é menor de idade");
            }

            else
            {
                Console.WriteLine("Entrada invalida, por gentileza insira um numero valido");
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
