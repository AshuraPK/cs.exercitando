using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EXERCITANDO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuInicial variavelCabecalho = new MenuInicial();
            variavelCabecalho.ExibirCabecalho();

            ExibirMenu variavelMenu = new ExibirMenu();
            variavelMenu.ExibirOpcoesMenu();
        }

    }


}

