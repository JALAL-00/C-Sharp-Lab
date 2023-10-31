using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Bird
{
    public string color { set; get; }
    public string size { set; get; }

    public Bird(string color, string size)
    {
        this.color = color;
        this.size = size;
    }

    public void birdInfo()
    {
        Console.WriteLine("Bird Class");
        Console.WriteLine("Color: " + color);
        Console.WriteLine("size: " + size);
    }
}

class Penguin : Bird
{
    public int lifespan { set; get; }

    public Penguin(string color, string size, int lifespan) : base(color, size)
    {
        this.lifespan = lifespan;
    }

    public void CanFly()
    {
        Console.WriteLine("Penguin can not fly");

    }
}

class Robin : Bird
{
    public int lifespan { set; get; }

    public Robin(string color, string size, int lifespan) : base(color, size)
    {
        this.lifespan = lifespan;
    }

    public void CanFly()
    {

        Console.WriteLine("Dual can fly");
    }
}

class Program
{
    static void Main()
    {
        Robin r = new Robin("Black", "Medium", 13);
        Penguin p = new Penguin("White and Black", "Big", 16);
        p.CanFly();
        p.birdInfo();
        Console.WriteLine();
        r.CanFly();
        r.birdInfo();

        Console.ReadKey();
    }
}


