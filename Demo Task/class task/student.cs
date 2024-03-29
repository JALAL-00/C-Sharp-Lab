


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter the number of students: ");
                int numStudents = Convert.ToInt32(Console.ReadLine());

               
                student[] students = new student[numStudents];

                for (int i = 0; i < numStudents; i++)
                {
                    Console.WriteLine("\nStudent " + (i + 1));
                    Console.WriteLine("Enter your name: ");
                    string name = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Enter your student ID: ");
                    string studentID = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Enter your CGPA: ");
                    float cgpa = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Enter total semesters: ");
                    int sem = Convert.ToInt32(Console.ReadLine());

                  
                    students[i] = new student(name, studentID, cgpa, sem);
               

            }

                
                for (int i = 0; i < numStudents; i++)
                {
                    Console.WriteLine("\nDetails of Student " + (i + 1));
                    students[i].display();
                    students[i].schollership();
                
            }

                Console.ReadKey();
            }

        }

        class student
    {
        public string name;
        private string studentID;
        private float cgpa;
        public int sem;

        public string stdid
        {
            get { return studentID; }
            set { studentID = value; }
        }
        public float Tcgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }

        public student() { }
        public student(string name, string studentID, float cgpa,int sem)
        {
            this.name = name;
            this.studentID = studentID;
            this.cgpa = cgpa;
            this.sem = sem;
        }
        public student (student a)
        {
            studentID = a.studentID;
            float cgpa = a.cgpa;
        }

        public void display()
        {
            Console.WriteLine("Name: " + name); 
            Console.WriteLine("Student ID: " + stdid);
            Console.WriteLine("CGPA: " + Tcgpa);
        }
        public void schollership()
        {
            if(Tcgpa>=3.75 && sem>=3)
            {
                Console.WriteLine("You have  schollership");

            }
            else
            {
                Console.WriteLine("No schollership");
            }
        }

    }
}




    class student
    {
        public string name;
        private string studentID;
        private float cgpa;
        public int sem;

        public string stdid
        {
            get { return studentID; }
            set { studentID = value; }
        }
        public float Tcgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }

        public student() { }
        public student(string name, string studentID, float cgpa, int sem)
        {
            this.name = name;
            this.studentID = studentID;
            this.cgpa = cgpa;
            this.sem = sem;
        }
        public student(student a)
        {
            studentID = a.studentID;
            float cgpa = a.cgpa;

        Console.WriteLine("For copy print:  " + stdid);
        Console.WriteLine("For copy print: " + Tcgpa);
    }

        public void display()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Student ID: " + stdid);
            Console.WriteLine("CGPA: " + Tcgpa);
        }
        public void schollership()
        {
            if (Tcgpa >= 3.75 && sem >= 3)
            {
                Console.WriteLine("You have  schollership");

            }
            else
            {
                Console.WriteLine("No schollership");
            }
        }
    }



