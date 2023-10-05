using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Min_Max
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, max, min;
            int[] arr = new int[100];
            Console.WriteLine("Enter the size of an array: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the elemets of an array: ");
            for( int i =0; i<n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            max = arr[0];
            for(int i =0; i<n; i++)
            {
                if(max < arr[i])
                {
                    max = arr[i];
                }
            }
            min = arr[0];
            for(int i =0; i<n; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Largest elements is: {0}", max);
            Console.WriteLine("Smallest elements is: {0}", min);
        }
    }
}
