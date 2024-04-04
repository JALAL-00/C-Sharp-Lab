using inheritancse_task;
using System;

namespace inheritance_task
{
    internal class main
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Person name: ");
            string personName = Convert.ToString(Console.ReadLine());
            Console.Write("Person Id: ");
            string personId = Convert.ToString(Console.ReadLine());
            Console.Write("Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mobile no : ");
            string mobileNumber = Convert.ToString(Console.ReadLine());
            Console.Write("Gender:m/f: " );
            char gender = Convert.ToChar(Console.ReadLine());
            Contact c1 = new Contact(personName, personId, age, mobileNumber, gender);
          
           


            Console.WriteLine();


            Console.Clear();


          
            
            
           

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Book name: ");
            string bookname = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Book author: ");
            string bookauthor = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Book id: ");
            string bookid = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Book type: ");
            string booktype = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Book copy: ");
            int bookcopy = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            book b1 = new book(bookname, bookauthor, bookid, booktype, bookcopy);
            
            Console.WriteLine("Enter book copy");
            int x = Convert.ToInt32(Console.ReadLine());
            b1.bookCopy(x);
            Console.WriteLine();
           

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Course name: ");
            string coursename = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Course code: ");
            string coursecode = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Course credit: ");
            int coursecredit = Convert.ToInt32(Console.ReadLine());
            course c2 = new course(coursename, coursecode, coursecredit);
          
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;


            b1.showInfo();
            c1.display();
            c2.ShowCourseInfo();
            c1.detectMobileOpeater();





            Console.ReadKey();
        }
    }
}
