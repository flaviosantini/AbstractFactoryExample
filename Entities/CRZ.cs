using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities.Interface;

namespace Entities
{
    public class CRZ : ISportsCar
    {
        public string Name()
        {
            return "Lamborghini Diablo";
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
            return "437";
        }

        public bool IsConvertible()
        {
            return false;
        }
    }
}
