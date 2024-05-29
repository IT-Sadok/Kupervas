using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Salon
{
    public int carCount{ get; private set; } 
    public void AddCar(string Brand)
    {
        carCount++;
    }
    public void RemoveCar()
    {
        carCount--;
    }
}
