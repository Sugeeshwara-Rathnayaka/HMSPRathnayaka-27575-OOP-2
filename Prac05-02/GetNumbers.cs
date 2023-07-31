using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac05_02
{
    public class GetNumbers
    {
        protected double num1;
        protected double num2;

        public void GetInput()
        {
            Console.Write("Enter the first number: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            num2 = double.Parse(Console.ReadLine());
        }
    }
}
