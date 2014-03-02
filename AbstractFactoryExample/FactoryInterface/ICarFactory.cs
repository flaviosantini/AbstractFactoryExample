using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities.Interface;

namespace AbstractFactoryExample.FactoryInterface
{
    public interface ICarFactory
    {
        IList<ISportsCar> GetSportsCars();
        IList<IFamilyCar> GetFamilyCars();
    }
}
