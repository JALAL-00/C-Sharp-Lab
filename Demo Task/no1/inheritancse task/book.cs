using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace inheritancse_task
{
    public class book
    {

        private string bookname;
        private string bookauthor;
        private string bookid;
        private string booktype;
        private int bookcopy;
        public static int bookcount = 1000;

        public book() { }

        public book(string bookname, string bookauthor, string bookid, string booktype, int bookcopy)
        {
            this.bookname = bookname;
            this.bookauthor = bookauthor;
            this.bookid = bookid;
            this.booktype = booktype;
            this.bookcopy = bookcopy;

        }


        public string Bookname
        {
            get { return bookname; }
            set { bookname = value; }
        }
        public string Bookauthor
        {
            get { return bookauthor; }
            set { bookauthor = value; }
        }
        public string Bookid
        {
            get { return bookid; }
            set { bookid = value; }
        }
        public string Booktype
        {
            get { return booktype; }
            set { booktype = value; }
        }
        public int Bookcopy
        {
            get { return bookcopy; }
            set { bookcopy = value; }
        }
        public void showInfo()
        {
            Console.WriteLine("Book Name: " + Bookname);
            Console.WriteLine("Book Author: " + bookauthor);
            Console.WriteLine("Book Id: " + bookid);
            Console.WriteLine("Book Type: " + booktype);
            Console.WriteLine("Book Copy: " + bookcopy);
            bookCopy(0);
            Console.WriteLine();

        }
        public void bookCopy(int x)
        {
            bookcopy = bookcopy + x;
            Console.WriteLine("Total book copy: " + bookcopy);
        }

    }
   
}


