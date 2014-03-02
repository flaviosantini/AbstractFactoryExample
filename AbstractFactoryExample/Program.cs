using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactoryExample;

namespace AbstractFactoryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            CarTypeChecker carTypeChecker = new CarTypeChecker();

            carTypeChecker.CheckCars(AbstractFactoryExample.Constants.MANUFACTURERS.PORSCHE);

            Console.WriteLine(string.Format("There are {0} Family cars for this brand.", carTypeChecker.familyCar.Count()));
            Console.WriteLine(string.Format("There are {0} Sports cars for this brand.", carTypeChecker.sportsCar.Count()));
            
            Console.WriteLine("Family cars:");
            foreach (var familyCar in carTypeChecker.familyCar)
            {
                Console.WriteLine(familyCar.Name().ToString());
            }

            Console.WriteLine("Sports cars:");
            foreach (var sportsCar in carTypeChecker.sportsCar)
            {
                Console.WriteLine(sportsCar.Name().ToString());
            }

            Console.ReadKey();
        }
    }
}
