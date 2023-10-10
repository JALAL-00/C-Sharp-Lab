using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] Array1 =
            {
                new int [] {11,22,33},
                new int []{ 44,55,66},
            };
            int[][] Array2 =
            {
                new int [] {77,88,99},
                new int [] {10,11,12},
            };



            int[][] mergedArray = new int[Array1.Length + Array2.Length][];
            for (int i = 0; i < Array1.Length; i++)
            {
                for (int j = 0; j < Array2.Length; j++)
                {
                    mergedArray[i] = Array1[i];
                    mergedArray[i + Array1.Length] = Array2[i];
                }
            }
            for (int i = 0; i < mergedArray.Length; i++)
            {
                for (int j = 0; j < mergedArray[i].Length; j++)
                {
                    Console.Write(mergedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
