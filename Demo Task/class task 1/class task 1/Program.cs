﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_task_1
{
    internal class Program
    {
        struct st
        {
            public string name;
            public int id;
          
            public string gender;
            float cgpa;
            float k;

            public void input()
            {
                Console.Write("YOUR NAME: ");

                name =Convert.ToString(Console.ReadLine());
                Console.Write("YOUR ID: ");
                id = Convert.ToInt32(Console.ReadLine());

                Console.Write("YOUR GENDER: ");
                gender = Convert.ToString(Console.ReadLine());
            }
            public void Tcgpa()
            {
                Console.WriteLine("Enter you cg from 1 sem to 4 th sem : ");
                float[] a = new float[4];
                for (float i = 0; i < 4; i++)
                {
                    a[(int)i] = float.Parse(Console.ReadLine());
                    while (a[(int)i] > 4 || a[(int)i] < 0)
                    {
                        Console.WriteLine("Please enter a grade between 0 and 4:");
                        a[(int)i] = float.Parse(Console.ReadLine());
                    }
                }

                float total = 0;
                for (float i = 0; i < 4; i++)
                {
                    total += a[(int)i];
                }

                float average = total / 4;
                k = average;
                
            }



            public void display()
            {
                Console.WriteLine("Your name: " + name);
                Console.WriteLine("Your id: " + id);
                Console.WriteLine("Your gender: " + gender);
                Console.WriteLine("YOur cgpa: "+ k);
                

            }
            


        }
        static void Main(string[] args)
        {
            Console.Write("How many student number you wanttt to calculate: ");
            int n=Convert.ToInt32(Console.ReadLine());
            st[] student = new st[n];
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("********************************************************");
                Console.WriteLine("                   Student no:"+(i+1));
                Console.WriteLine();
                student[i].input();
                student[i].Tcgpa();
                Console.WriteLine();
                student[i].display();
                Console.WriteLine("                   END for student no"+(i+1));
                Console.WriteLine("********************************************************");





            }
          
            Console.ReadKey();
          






        }
    }
}
