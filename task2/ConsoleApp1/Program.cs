using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">>> for loop <<<");
            for(int i = 1; i <= 12; i++)
            {
                Console.WriteLine("7*" + i + "=" + (7*i));
            }
            Console.WriteLine(">>> while loop <<<");
            int j = 1;
            while ( j <= 12)
            {
                Console.WriteLine("7*" + j + "=" + (7 * j));
                j++;
            }
            Console.WriteLine(">>> do/while loop <<<");
            int k = 1;
            do
            {
                Console.WriteLine("7*" + k + "=" + (7 * k));
                k++;
            }
            while (k <= 12);
       

        }
    }
}
