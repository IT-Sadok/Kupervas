using ConsoleApp2;
using System;
using System.Security.Cryptography.X509Certificates;
Salon salon = new Salon();
while (true)
{
    Console.WriteLine("Choose the option");
    Console.WriteLine("1.Add car");
    Console.WriteLine("2.Remove car");
    Console.WriteLine("3.Show all cars");
    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            AddCar(salon);
            break;
        case "2":
            RemoveCar(salon);
            break;
        case "3":
            ShowAllCars(salon);
            break;
    }
}
static void AddCar(Salon salon)
{
    Console.WriteLine("Введіть марку авто");
    string Brand = Console.ReadLine();
    Console.WriteLine("Введіть модель авто");
    string Model = Console.ReadLine();
    Console.WriteLine("Введіть рік випуску авто");
    int Year = int.Parse(Console.ReadLine());
    salon.AddCar(Brand, Model,Year);
    Console.WriteLine($"Car added successfully: {salon.carCount}");
}
static void RemoveCar(Salon salon)
{
    salon.RemoveCar();
    if (salon.carCount > 0)
    {
        Console.WriteLine($"Car removed successfully: {salon.carCount}");
    }
    else
    {
        Console.WriteLine("No car to remove");
    }
}
static void ShowAllCars(Salon salon)
{
    List <Car> cars = salon.GetAllCars();
    Console.WriteLine("Car list: ");
    if (cars.Count > 0)
    {
        foreach(Car car in cars)
        {
            Console.WriteLine(car);
        }

    }
    else
    {
        Console.WriteLine("No cars in the salon!");
    }
}
