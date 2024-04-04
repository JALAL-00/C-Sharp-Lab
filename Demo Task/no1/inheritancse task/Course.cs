using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritancse_task
{
    public class course
    {
        private string Coursename;
        private string CourseCode;
        private int CourseCredit;

        public course() { }

        public course(string Coursename, string CourseCode, int CourseCredit)
        {
            this.Coursename = Coursename;
            this.CourseCode = CourseCode;
            this.CourseCredit = CourseCredit;
        }

        public string coursename
        {
            get { return Coursename; }
            set { Coursename = value; }
        }
        public string coursecode
        {
            get { return CourseCode; }
            set { CourseCode = value; }
        }
        public int coursecredit
        {
            get { return CourseCredit; }
            set { CourseCredit = value; }
        }
        public void ShowCourseInfo()
        {
            Console.WriteLine("Course Name: " + Coursename);
            Console.WriteLine("Course Code: " + CourseCode);
            Console.WriteLine("Course Credit: " + CourseCredit);
            Console.WriteLine();
        }
       
    }
}
