
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Car
    {
        private string Brand { get; set; }
        private string Model { get; set; }
        private int Year { get; set; }
        public Car(string Brand,string Model, int Year)
        {
            this.Brand = Brand;
            this.Model = Model;
            this.Year = Year;
        }
        public override string ToString()
        {
            return $"{Brand} {Model} {Year}" ;
        }
    }
}
