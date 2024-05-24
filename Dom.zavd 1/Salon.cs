using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Salon
{
    private int carCount;
    public Salon()
    {
        carCount = 0;
    }
    public void AddCar(string Brand)
    {
        carCount++;
        Console.WriteLine("Car added successfully: " + carCount );

    }
    public void RemoveCar()
    {
        if ( carCount > 0 )
        {
            carCount--;
            Console.WriteLine("Car removed successfully: " + carCount);
        }
        else
        {
            Console.WriteLine("No car to remove");
        }
    }
}
