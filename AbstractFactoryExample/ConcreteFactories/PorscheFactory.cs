using AbstractFactoryExample.FactoryInterface;
using Entities;
using Entities.Interface;
using System.Collections.Generic;

namespace AbstractFactoryExample.ConcreteFactories
{
    /// <summary>
    /// Represents the Porsche Concrete Factory
    /// </summary>
    public class PorscheFactory : ICarFactory
    {
        public IList<ISportsCar> GetSportsCars()
        {
            IList<ISportsCar> sportsCar = new List<ISportsCar>();

            sportsCar.Add(new Carrera());
            return sportsCar;
        }

        public IList<IFamilyCar> GetFamilyCars()
        {
            IList<IFamilyCar> familyCar = new List<IFamilyCar>();

            familyCar.Add(new Cayenne());
            return familyCar;
        }
    }
}
