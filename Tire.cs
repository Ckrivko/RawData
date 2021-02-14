using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Tire
    {
        public Tire( double pressure,int  age)
        {
            TireAge = age;
            TirePressure = pressure;
        }
       
        public int TireAge { get; set; }
        public double TirePressure { get; set; }


    }
}
