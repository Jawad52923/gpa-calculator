using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace for_while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 5)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i + " ");
                }

                Console.WriteLine();
                i++;
            }
        }
    }
}
