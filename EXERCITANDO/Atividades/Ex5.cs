using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EXERCITANDO
{
    internal class Ex5
    {

        public void atividade5()
        {
            Console.Clear();
            Console.WriteLine("5. Escreva um programa que verifique se uma letra fornecida pelo usuário é uma vogal ou uma consoante.");

            string vogal = Console.ReadLine();


            if (vogal == "a" || vogal == "e" || vogal == "i" || vogal == "o" || vogal == "u")
            {
                Console.WriteLine("É vogal");
            }
            else
            {
                Console.WriteLine("é consoante");
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
