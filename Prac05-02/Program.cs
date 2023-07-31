using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac05_02
{
    public class Program
    {
        public static void Main()
        {
            try
            {
                GetNumbers getNumbers = new GetNumbers();
                getNumbers.GetInput();

                Summation summation = new Summation();
                double sum = summation.CalculateSummation();

                Subtraction subtraction = new Subtraction();
                double difference = subtraction.CalculateSubtraction();

                Multiplication multiplication = new Multiplication();
                double product = multiplication.CalculateMultiplication();

                Division division = new Division();
                double quotient = division.CalculateDivision();

                Console.WriteLine("Summation: " + sum);
                Console.WriteLine("Subtraction: " + difference);
                Console.WriteLine("Multiplication: " + product);
                Console.WriteLine("Division: " + quotient);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter valid numbers.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
