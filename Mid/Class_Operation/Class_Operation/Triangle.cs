using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Operation
{
    class Triangle
    {
        int x, y, z;


        public void Showinfo()
        {
            Console.WriteLine("x={0} y={1} z={2}", x, y, z);
        }

        public void TestTriangle(int a, int b, int c)
        {
            this.x = a;
            this.y = b;
            this.z = c;
            if ((x == z) && (x == y))
            { Console.WriteLine("3 equal sides (equilateral)"); }

            else if (x == y || y == z || x == z)
                { Console.WriteLine("2 Equal sides (isosceles)"); }

            else
            { Console.WriteLine("No Equal Sides (scalene)"); }
                    
             
         

        }
            


    }
}
