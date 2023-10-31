using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Human
{
    public string name { get; set; }
    public int age { get; set; }
    public Human(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public void humaninfo()
    {
        Console.WriteLine("Human Info");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine();
    }
}


class Student : Human
{
    public double cg { get; set; }

    public Student(string name, int age, double cg) : base(name, age)
    {
        this.cg = cg;
    }

    public void studentInfo()
    {
        Console.WriteLine("Student Info");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("CG: " + cg);
        Console.WriteLine();
    }
}

class ExStudent : Student
{
    public int graduationyear { get; set; }

    public ExStudent(string name, int age, double cg, int graduationyear) : base(name, age, cg)
    {
        this.graduationyear = graduationyear;
    }

    public void exstudentInfo()
    {
        Console.WriteLine("Ex Student Info");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("CG: " + cg);
        Console.WriteLine("Graduation Year: " + graduationyear);
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Human h1 = new Human("JALAL", 23);
        h1.humaninfo();

        Student s2 = new Student("JALAL", 22, 3.7);
        s2.studentInfo();

        ExStudent ex = new ExStudent("JALAL", 22, 3.7, 2020);
        ex.exstudentInfo();


        Console.ReadKey();
    }
}
