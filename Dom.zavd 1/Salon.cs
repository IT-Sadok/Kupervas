
using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Salon
{
    private List<Car> cars = new List<Car>();
    public int carCount { get; private set; }
    public void AddCar(string Brand, string Model, int Year)
    {
        cars.Add(new Car(Brand, Model, Year));
        carCount++;
    }
    public void RemoveCar()
    {
        carCount--;
    }
    public void ShowCars()
    {
        foreach (Car car in cars)
        {
            Console.WriteLine(car);
        }
    }
    public List<Car> GetAllCars() 
    {
        return new List<Car>(cars);
    }
}
