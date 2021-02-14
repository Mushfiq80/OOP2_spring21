using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] arr1 = { 2, 4, 5, 8, 2, 4 };
            int[] arr2 = new int[6];
            for(int i=0; i < arr1.Length; i++)
            {
                arr2[i] = arr1[i];
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }

            // Duplicate Array Count
            int count = 0;
            for(int i=0;i< arr1.Length; i++)
            {
                for(int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                        count++;
                }
            }
            Console.WriteLine("Duplicate Number of Elements are {0}", count);
            
            int[] arr3 = new int[10];
            int ctr = 0;
            
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] != arr2[j])
                    {
                        arr3[i] = arr2[j];
                        
                    }
                    
                }
                ctr++;
            }
            Console.WriteLine("Unique Elements count {0}", ctr);
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr3[i]);
            }



        }
    }
}
