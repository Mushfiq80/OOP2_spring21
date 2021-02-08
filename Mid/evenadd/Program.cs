using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenadd
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n = 100;
            Console.WriteLine("The even numbers here(2-100): ");
            for (i = 1; i <= n; i++)
            {
                Console.Write("{0} ", 2 * i);
            }
        }
    }
}
