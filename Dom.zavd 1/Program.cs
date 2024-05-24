using System;

Salon cars = new Salon();
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
static void AddCar(Salon cars)
{
  Console.WriteLine("Введіть марку авто");
  string Brand = Console.ReadLine();
  cars.AddCar(Brand);
}
static void RemoveCar(Salon cars)
{
 cars.RemoveCar();
}
  


