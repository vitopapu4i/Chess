using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame2
{
    public class Program
    {
        public static void Main()
        {

            var game = new Game();
            game.Run();
            Console.ReadKey();
        }
    }
}
