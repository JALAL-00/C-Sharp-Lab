using System;

namespace car
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            
            Car[] c1 = new Car[2];
            for (int i = 0; i < 2; i++)
            {
                c1[i] = new Car();
                Console.WriteLine("Car no:" + (i + 1));

                Console.Write("Car ID: ");
                c1[i].carId = Convert.ToInt32(Console.ReadLine());
                Console.Write("Car Name: ");
                
                c1[i].CnName = Convert.ToString(Console.ReadLine());
                Console.Write("Car price:");
                c1[i].cprice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Car id: " + c1[i].carId + "\n" + "Car name:" + c1[i].CnName + "\n" + c1[i].cprice);

            }

            Console.ReadLine();
        }

    }
}
class Car
{
    public int carId;
    private string carName;
    private int price;
    public int cprice
    {
        set { price = value; }
        get { return price; }
    }
    public string CnName
    {
        get { return carName; }
        set { carName = value; }

    }
    public Car()
    {

    }
    public Car(int carId, int cprice)
    {
        this.carId = carId;
        this.cprice = cprice;
        Console.WriteLine(carId + "\n");
        Console.WriteLine(cprice + "\n");
    }
   
    
}

