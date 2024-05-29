using System;
Salon salon = new Salon();
while (true)
{
    Console.WriteLine("Choose the option");
    Console.WriteLine("1.Add car");
    Console.WriteLine("2.Remove car");
    string choice = Console.ReadLine();
    switch (choice)
{
        case "1":
            AddCar(salon);
            break;
        case "2":
            RemoveCar(salon);
            break;
    }
}
static void AddCar(Salon salon) 
{
    Console.WriteLine("Введіть марку авто");
    string Brand = Console.ReadLine();
    salon.AddCar(Brand);
    Console.WriteLine($"Car added successfully: {salon.carCount}");
}
static void RemoveCar(Salon salon) 
{
    salon.RemoveCar();
    if(salon.carCount > 0)
    {
        Console.WriteLine($"Car removed successfully: {salon.carCount}");
    }
    else
    {
        Console.WriteLine("No car to remove");
    }
}
