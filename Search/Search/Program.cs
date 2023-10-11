using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter for search: ");
            int n = int.Parse(Console.ReadLine());
            bool flag = false;

            int[][] JaggedArry = new int[][]
            {
                new int [] { 1, 2 },
                new int [] { 5, 6, 7, 8 },
                new int [] { 9, 10, 11, 12, 13 }
            };

            for(int i =0; i< JaggedArry.Length; i++)
            {
                for(int j =0; j< JaggedArry[i].Length; j++)
                {
                    if (JaggedArry[i][j] == n)
                    {
                        flag = true;
                        Console.WriteLine($"Value found at: {i} {j}" );
                        break;
                    }
                }
                if(flag == true)
                {
                    break;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("Value not found");
            }
        }
    }
}
