using System.Collections.Generic;
using AbstractFactoryExample.ConcreteFactories;
using AbstractFactoryExample.FactoryInterface;
using Entities.Interface;

namespace AbstractFactoryExample
{
    public class CarTypeChecker
    {
        public IList<ISportsCar> sportsCar;
        public IList<IFamilyCar> familyCar;

        ICarFactory carFactory;

        public void CheckCars(AbstractFactoryExample.Constants.MANUFACTURERS manufacturer)
        {
            switch (manufacturer)
            {
                case Constants.MANUFACTURERS.PORSCHE:
                    carFactory = new PorscheFactory();
                    break;
                case Constants.MANUFACTURERS.HONDA:
                    carFactory = new HondaFactory();
                    break;
                case Constants.MANUFACTURERS.DODGE:
                    carFactory = new DodgeFactory();
                    break;
                default:
                    break;
            }

            this.sportsCar = carFactory.GetSportsCars();
            this.familyCar = carFactory.GetFamilyCars();

        }

    }
}
