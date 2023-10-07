using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNumber, endNumber;
            Console.Write("Enter The Start Number: ");
            startNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the End Number : ");
            endNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("The Prime Numbers between {startNumber} and {endNumber} are : ");

            for (int i = startNumber; i <= endNumber; i++)
            {
                int counter = 0;

                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                        break;
                    }
                }

                if (counter == 0 && i != 1)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.ReadKey();
        }
    }
}
