using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities.Interface
{
    /// <summary>
    /// Represents the type of car Family
    /// </summary>
    public interface IFamilyCar
    {
        string Name();
        string Traction();
        string RowSeatings();
        string HorsePower();
    }
}
