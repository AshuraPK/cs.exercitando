using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EXERCITANDO
{
    internal class Ex6
    {

        public void atividade6()
        {
            Console.Clear();
            Console.WriteLine("6. Faça um programa que leia a nota de um aluno e informe se ele está aprovado (nota maior ou igual a 7), em recuperação (nota entre 5 e 7) ou reprovado (nota menor que 5).");

            Console.WriteLine("qual a sua nota?");
            int numeroEscolhido = int.Parse(Console.ReadLine());

            if (numeroEscolhido >= 7)
            {
                Console.WriteLine("você esta aprovado");
            }
            else if (numeroEscolhido == 5 || numeroEscolhido == 6)
            {
                Console.WriteLine("esta recuperação");
            }
            else if (numeroEscolhido < 5)
            {
                Console.WriteLine("está reprovado");
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
