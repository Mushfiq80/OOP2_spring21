using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grading
{
    class Program
    {
        static void Main(string[] args)
        {
            int To, Phy = 82, chem = 80, bio = 75, math = 89, com = 84;
            
            To = (Phy + chem + bio + math + com) / 5;
            if ((To< 50))
            {
                Console.WriteLine("FAILED");
            }

            if ((To >= 50) && (To <= 75))
            {
                Console.WriteLine(" C+");
            }

            else if ((To >= 75) && (To <= 79))
            {
                Console.WriteLine("B");
            }

            else if ((To >= 80) && (To < 85))
            {
                Console.WriteLine("A ");
            }
            
            else if ((To >= 85) && (To < 89))
            {
                Console.WriteLine("A ");
            }

            else if (To >= 90)
            {
                Console.WriteLine("A+");
            }
        }
    }
}
