using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Car
{
    private string Brand { get; set; }
    public Car(string _Brand)
    {
        Brand = _Brand;
    }
    public override string ToString()
    {
        return $"Brand: {Brand}";
    }
}
public class Salon
{
    private Car currentCar;
    public void AddCar(string Brand)
    {
        currentCar = new Car(Brand);
        Console.WriteLine("Car added successfully");

    }
    public void RemoveCar()
    {
        currentCar = null;
        Console.WriteLine("Car removed successfully.");
    }
}
