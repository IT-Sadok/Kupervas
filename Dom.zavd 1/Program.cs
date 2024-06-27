using ConsoleApp2;
using System.Threading.Tasks.Dataflow;
using System.IO;

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
    Console.Write("Введіть марку авто: ");
    string Brand = Console.ReadLine();
    Console.Write("Введіть модель авто: ");
    string Model = Console.ReadLine();
    Console.Write("Введіть рік випуску авто: ");
    int Year = int.Parse(Console.ReadLine());
    string path = "text_document.txt";
    using (StreamWriter writer = new StreamWriter(path, append: true))
    {
        writer.WriteAsync($"Марка: {Brand}");
        writer.WriteAsync($"Модель: {Model}");
        writer.WriteAsync($"Рік випуску: {Year}");
    }
    salon.AddCar(Brand, Model, Year);
    Console.WriteLine($"Car added successfully: {salon.CarCount}");
}
static void RemoveCar(Salon salon)
{
    salon.RemoveCar();
    if (salon.CarCount > 0)
    {
        Console.WriteLine($"Car removed successfully: {salon.CarCount}");
    }
    else
    {
        Console.WriteLine("No car to remove");
    }
}
static void ShowAllCars(Salon salon)
{
    List<Car> cars = salon.Cars;
    if (salon.CarCount > 0)
    {
        string carList = string.Join(", ",cars.Select(car => car.ToString()));
        Console.WriteLine($"Car list: {carList}" );
    }
    else
    {
        Console.WriteLine("No cars in the salon!");
    }
}
