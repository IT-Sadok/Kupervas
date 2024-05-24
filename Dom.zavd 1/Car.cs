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
        public Car(string Brand)
        {
            Brand = Brand;
        }
        public override string ToString()
        {
            return Brand;
        }
    }
}
