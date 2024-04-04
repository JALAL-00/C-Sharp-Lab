using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritancse_task
{
    internal class Contact
    {
        private string personName;
        private string personId;
        private int age;
        private string mobileNumber;
        private char gender;
        public Contact() { }
        public Contact(string personName, string personId, int age, string mobileNumber, char gender)
        {
            this.personName = personName;
            this.personId = personId;
            this.age = age;
            this.mobileNumber = mobileNumber;
            this.gender = gender;
        }
        public string PersonName
        {
            get { return personName; }
            set { personName = value; }
        }
        public string PersonId
        {
            get { return personId; }
            set { personId = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public char Gender
        {
            set { gender = value; }
            get { return gender; }

        }
        public string MobileNumber
        {
            get { return mobileNumber; }
            set { mobileNumber = value; }
        }
        public void display()
        {
            Console.WriteLine("Person Name: " + personName);
            Console.WriteLine("Person Id: " + personId);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Mobile no : " + mobileNumber);
            Console.WriteLine("Gender:  " + gender);
            Console.WriteLine();
        }

        public void detectMobileOpeater()
        {
            Console.WriteLine("Enter mobile operator name: ");  
            string mobileOperator = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter mobile opertor: "+mobileOperator);
        }
    }
}
