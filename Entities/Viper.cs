using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities.Interface;

namespace Entities
{
    public class Viper : ISportsCar
    {
        public string Name()
        {
            return "Dodge Viper";
        }

        public string Traction()
        {
            return "2x4";
        }

        public string RowSeatings()
        {
            return "1";
        }

        public string HorsePower()
        {
            return "450";
        }

        public bool IsConvertible()
        {
            return true;
        }
    }
}
