using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities.Interface;

namespace Entities
{
    public class Carrera : ISportsCar
    {
        public string Name()
        {
            return "Porsche Carrera";
        }

        public string Traction()
        {
            return "2x4";
        }

        public string RowSeatings()
        {
            return "2";
        }

        public string HorsePower()
        {
            return "250hp";
        }

        public bool IsConvertible()
        {
            return true;
        }
    }
}
