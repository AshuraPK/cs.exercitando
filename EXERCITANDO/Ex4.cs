using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EXERCITANDO
{
    internal class Ex4
    {

        public static void atividade4()
        {
            Console.Clear();
            Console.WriteLine("4. Crie um programa que leia três números e determine qual é o maior.");

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine(num1 + "É maior");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine(num2 + "É maior");
            }

            else if (num3 > num1 && num3 > num2) ;
            {
                Console.WriteLine(num3 + "É maior");
            }

            Thread.Sleep(3000);
            Console.Clear();
            ExibirCabecalho();
            ExibirOpcoesMenu();
        }
    }
}
