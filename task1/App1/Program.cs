using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please enter thr starting point");
            int start = int.Parse(Console.ReadLine());
            Console.Write("please enter thr ending point");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine("N\t10*N\t100*N\t1000*N");
            Console.WriteLine(".\t....\t.....\t......");

            Console.WriteLine(">>> for loop <<<");
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine($"{i}    {i*10}    {i*100}    {i*1000}");
                
            }
            Console.WriteLine(">>> while loop <<<");
            int j = start;
            while (j <= end)
            {
                Console.WriteLine($"{j}    {j*10}    {j*100}    {j*1000}");
                j++;
            }
            Console.WriteLine(">>> do/while loop <<<");
            int k = start;
            do
            {
                Console.WriteLine($"{k}    {k*10}    {k*100}    {k*1000}");
                k++;
            }
            while (k <= end);

        }
    }
}
