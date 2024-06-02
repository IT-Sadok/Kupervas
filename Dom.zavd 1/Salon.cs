
using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Salon
{
    public List<Car> cars = new List<Car>();
    public int CarCount { get; private set; }
    public void AddCar(string Brand, string Model, int Year)
    {
        cars.Add(item: new Car(Brand, Model, Year));
        CarCount++;
    }
    public void RemoveCar()
    {
        cars.RemoveAt(cars.Count - 1);
        CarCount--;
    }
    public List<Car> GetAllCars() 
    {
        return new List<Car>(cars);
    }
}
