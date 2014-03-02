using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities.Interface;

namespace Entities
{
    public class GrandCaravan : IFamilyCar
    {
        public string Name()
        {
            return "Dodge Grand Caravan";
        }

        public string Traction()
        {
            return "4x4";
        }

        public string RowSeatings()
        {
            return "3";
        }

        public string HorsePower()
        {
            return "275";
        }
    }
}
