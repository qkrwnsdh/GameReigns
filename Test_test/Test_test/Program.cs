using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_test
{
    public class Program
    {

        static void Main(string[] args)
        {
            ConsoleKeyInfo key;

            int kpos = 0;
            
            int[] map = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition(i * 5,0);

                    map[i] = i + 5;

                Console.Write("{0,5}", map[i]);
            }

            Console.WriteLine();

            key = Console.ReadKey(true);

            if ('a' == key.KeyChar || key.KeyChar == 'A')
            {
                key = Console.ReadKey(true);
                if (ConsoleKey.Enter == key.Key)
                { 
                
                }
            }
        }

    }
}
