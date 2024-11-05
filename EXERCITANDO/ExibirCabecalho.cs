using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCITANDO
{
    internal class MenuInicial
    {

        public static void ExibirCabecalho()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("════════════════════════════════════════════════");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("autor: Walmir Sousa");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("════════════════════════════════════════════════");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
███████╗██╗░░██╗███████╗██████╗░░█████╗░██╗████████╗░█████╗░███╗░░██╗██████╗░░█████╗░
██╔════╝╚██╗██╔╝██╔════╝██╔══██╗██╔══██╗██║╚══██╔══╝██╔══██╗████╗░██║██╔══██╗██╔══██╗
█████╗░░░╚███╔╝░█████╗░░██████╔╝██║░░╚═╝██║░░░██║░░░███████║██╔██╗██║██║░░██║██║░░██║
██╔══╝░░░██╔██╗░██╔══╝░░██╔══██╗██║░░██╗██║░░░██║░░░██╔══██║██║╚████║██║░░██║██║░░██║
███████╗██╔╝╚██╗███████╗██║░░██║╚█████╔╝██║░░░██║░░░██║░░██║██║░╚███║██████╔╝╚█████╔╝
╚══════╝╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝░╚════╝░╚═╝░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░░╚════╝░");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("════════════════════════════════════════════════");
            Console.ResetColor();
        }

    }
}
