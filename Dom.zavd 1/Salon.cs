using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Salon
{
    public List<Car> cars = new List<Car>();
    public int CarCount => cars.Count;
    public void AddCar(string Brand, string Model, int Year)
    {
        cars.Add(item: new Car(Brand, Model, Year));
    }
    public void RemoveCar()
    {
        cars.RemoveAt(cars.Count);
    }
    public List<Car> Cars { get; private set; }
}
