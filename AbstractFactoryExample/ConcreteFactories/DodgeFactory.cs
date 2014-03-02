using Entities.Interface;
using AbstractFactoryExample.FactoryInterface;
using Entities;
using System.Collections.Generic;

namespace AbstractFactoryExample.ConcreteFactories
{
    /// <summary>
    /// Represents the Concrete Dodge Factory
    /// </summary>
    public class DodgeFactory : ICarFactory
    {
        public IList<ISportsCar> GetSportsCars()
        {
            IList<ISportsCar> sportsCar = new List<ISportsCar>();

            sportsCar.Add(new Viper());
            return sportsCar;
        }

        public IList<IFamilyCar> GetFamilyCars()
        {
            IList<IFamilyCar> familyCar = new List<IFamilyCar>();

            familyCar.Add(new GrandCaravan());
            return familyCar;
        }

    }
}
