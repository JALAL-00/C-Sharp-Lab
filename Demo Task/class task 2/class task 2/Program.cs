using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int[,] arr1 = new int[2, 2];
            int[,] arr2 = new int[2, 2];
            int[,] arr3 = new int[2, 2];
            Console.WriteLine("Enter the elements of first matrix");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j <2; j++)
                {
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter the elements of second matrix");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j <2; j++)
                {
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter what you want to do");
            Console.WriteLine("1.Plus");
            Console.WriteLine("2.Minus");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.exit");
            Console.WriteLine("Enter your choice");
            int n=Convert.ToInt32(Console.ReadLine());
          
            while (n != 4)
            {
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Addition of two matrices is :");
                        for (int i = 0; i < 2; i++)
                        {
                            for (int j = 0; j < 2; j++)
                            {

                                arr3[i, j] = arr1[i, j] + arr2[i, j];
                                Console.Write(arr3[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 2:
                        Console.WriteLine("Subtraction of two matrices is :");
                        for (int i = 0; i < 2; i++)
                        {
                            for (int j = 0; j < 2; j++)
                            {

                                arr3[i, j] = arr1[i, j] - arr2[i, j];
                                Console.Write(arr3[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 3:
                        Console.WriteLine("Multiplication of two matrices is :");
                        for (int i = 0; i < 2; i++)
                        {
                            for (int j = 0; j < 2; j++)
                            {

                                arr3[i, j] = 0;
                                for (int k = 0; k < 2; k++)
                                {
                                    arr3[i, j] += arr1[i, k] * arr2[k, j];
                                }
                                Console.Write(arr3[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
                Console.WriteLine("************************************************************");
                Console.WriteLine("Enter what you want to do");
                Console.WriteLine("1.Plus");
                Console.WriteLine("2.Minus");
                Console.WriteLine("3.Multiplication");
                Console.WriteLine("4.exit");
                Console.WriteLine("Enter your choice");
                Console.WriteLine("************************************************************");  
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }


           
               
            Console.ReadLine();


        }
        }
    }
