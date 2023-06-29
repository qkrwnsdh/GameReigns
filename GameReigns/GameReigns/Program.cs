using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameReigns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            Start gameStart = new Start();

            gameStart.GameStart();
        }
    }
}
