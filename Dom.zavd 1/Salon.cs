using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Salon
{
    public int carCount = 0;
    public void AddCar(string Brand)
    {
        carCount++;
    }
    public void RemoveCar()
    {
        if ( carCount > 0 )
        {
            carCount--;
            Console.WriteLine("Car removed successfully: " +carCout ) // But is it good here according to S principle?
        }
        else
        {
            Console.WriteLine("No car to remove");
        }
    }
}
