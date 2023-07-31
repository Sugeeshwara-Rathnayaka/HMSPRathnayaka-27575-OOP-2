using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac05_04
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Enter the size of the arrays: ");
            int size = int.Parse(Console.ReadLine());

            int[] array1 = new int[size];
            int[] array2 = new int[size];
            int[] vectorSum = new int[size];
            int[] vectorProduct = new int[size];

    
            Console.WriteLine("Enter values for the first array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                array1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter values for the second array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                array2[i] = int.Parse(Console.ReadLine());
            }

            int scalarSum = 0;
            for (int i = 0; i < size; i++)
            {
                scalarSum += array1[i] + array2[i];
            }

   
            for (int i = 0; i < size; i++)
            {
                vectorSum[i] = array1[i] + array2[i];
            }

  
            for (int i = 0; i < size; i++)
            {
                vectorProduct[i] = array1[i] * array2[i];
            }

   
            Console.WriteLine("Scalar Sum: " + scalarSum);

            Console.WriteLine("Vector Sum:");
            DisplayArray(vectorSum);

            Console.WriteLine("Vector Product:");
            DisplayArray(vectorProduct);
        }

    
        public static void DisplayArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
