using System;
salon cars = new salon();
while (true)
{
    Console.WriteLine("Choose the option");
    Console.WriteLine("1.Add car");
    Console.WriteLine("2.Remove car");
    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            AddCar(cars);
            break;
        case "2":
            RemoveCar(cars);
            break;
    }
    static void AddCar(salon cars)
    {
        Console.WriteLine("Введіть марку авто");
        string Brand = Console.ReadLine();
        cars.AddCar(Brand);
    }
    static void RemoveCar(salon cars)
    {
        cars.RemoveCar();
    }
}




