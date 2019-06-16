using CarDriving.Operations.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDriving.Operations.Extensions
{
    public static class Enums
    {
        public static void IsClockwise(this Orientation value, Orientation preOrientation)
        {
            Orientation[] orientation = Enum.GetValues(typeof(Orientation)) as Orientation[];
            if (preOrientation == orientation.FirstOrDefault() && value == orientation.LastOrDefault() ||
                (preOrientation != orientation.LastOrDefault() && value != orientation.FirstOrDefault() && value < preOrientation))
            {
                throw new ArgumentException("Orienation is not clockwise");
            }
        }
    }
}
