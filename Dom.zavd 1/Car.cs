using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Car
    {
        public Car(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }

        private string Brand { get; set; }
        private string Model { get; set; }
        private int Year { get; set; }
        public record Car(string Brand, string Model, int Year);
    }
}
