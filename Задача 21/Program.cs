using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Задача21
{
    class Program
    {
        const int n = 11;
        static int[] path = new int[n] {1, 5, 0, 10, 2, 6, 0, 8, 0, 10, 1};
        static void Main(string[] args)
        {
            ThreadStart threadStart = new ThreadStart(Gardner1);
            Thread thread = new Thread(threadStart);
            thread.Start();

            Gardner2();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{path[i]} ");
            }
           
        }

        static void Gardner1()
        {
            for (int i = 0; i < n; i++) 
            {
            if (path[i]>=0)
                
                {
                    int delay = path[i];
                    path[i] = -1;
                    Thread.Sleep(delay);
                }
             }
        }
        static void Gardner2()
        {
            for (int i = n-1; i >=0; i--)
            {
                if (path[i]>=0) 
                {
                int delay = path[i];
                    path[i] = -2;
                Thread.Sleep(delay);
                }
            }
        }
    }
}
