using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = new int[3,3];
            Console.WriteLine("Enter The elements of the 1st  matrix: ");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr1[i,j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }


            int[,] arr2 = new int[3,3];
            Console.WriteLine("Enter The elements of the 2nd matrix: ");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr2[i,j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

            int[,] arr3 = new int[3,3];
            Console.WriteLine("The 3rd Matrix: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr3[i,j] = arr1[i,j] + arr2[i,j];
                    Console.Write(arr3[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
