using AbstractFactoryExample.FactoryInterface;
using Entities;
using Entities.Interface;
using System.Collections.Generic;

namespace AbstractFactoryExample.ConcreteFactories
{
    /// <summary>
    /// Representes the Honda Concrete Factory
    /// </summary>
    public class HondaFactory : ICarFactory
    {
        public IList<ISportsCar> GetSportsCars()
        {
            IList<ISportsCar> sportsCar = new List<ISportsCar>();

            sportsCar.Add(new CRZ());
            return sportsCar;
        }

        public IList<IFamilyCar> GetFamilyCars()
        {
            IList<IFamilyCar> familyCar = new List<IFamilyCar>();

            familyCar.Add(new Tourer());
            return familyCar;
        }
    }
}
