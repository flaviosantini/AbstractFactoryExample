using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities.Interface
{
    /// <summary>
    /// Represents de Family type of car
    /// </summary>
    public interface ISportsCar
    {
        string Name();
        bool IsConvertible();
        string Traction();
        string RowSeatings();
        string HorsePower();
    }
}
