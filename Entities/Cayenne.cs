using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities.Interface;

namespace Entities
{
    public class Cayenne : IFamilyCar
    {
        public string Name()
        {
            return "Porsche Cayenne";
        }

        public string Traction()
        {
            return "4x4";
        }

        public string RowSeatings()
        {
            return "2";
        }

        public string HorsePower()
        {
            return "283";
        }
    }
}
