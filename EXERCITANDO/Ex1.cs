using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EXERCITANDO
{
    internal class Ex1
    {
        public static void atividade1()
        {
            Console.Clear();
            Console.WriteLine("1.Escreva um programa que verifique se um número fornecido pelo usuário é positivo, negativo ou zero.");

            int num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("positivo");
            }
            else if (num < 0)
            {
                Console.WriteLine("negativo");
            }

            else
            {
                Console.WriteLine("numero igual a 0");
            }

            Thread.Sleep(3000);
            Console.Clear();
            ExibirCabecalho();
            ExibirOpcoesMenu();

        }
    }
}
