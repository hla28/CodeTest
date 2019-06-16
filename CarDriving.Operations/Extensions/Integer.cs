using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDriving.Operations.Core.Enums;

namespace CarDriving.Operations.Extensions
{
    public static class Integer
    {
        public static void WithinRange(this int value)
        {
            if (value > (int)Boundary.Max || value < (int)Boundary.Min)
                throw new ArgumentOutOfRangeException("Value is out of range");
        }
    }
}
