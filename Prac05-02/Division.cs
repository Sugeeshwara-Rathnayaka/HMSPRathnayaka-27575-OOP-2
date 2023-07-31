using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac05_02
{
    public class Division : GetNumbers
    {
        public double CalculateDivision()
        {
            if (num2 == 0)
            {
                throw new ArgumentException("Division by zero is not allowed.");
            }
            return num1 / num2;
        }
    }
}
