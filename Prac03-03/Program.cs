using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac03_03
{
    public class ArrayProcessor
    {
        private int[] arr;

        public ArrayProcessor(int size)
        {
            arr = new int[size * 2]; 
        }

        public void TakeUserInputs()
        {
            for (int i = 0; i < arr.Length; i += 2)
            {
                Console.Write("Enter a number: ");
                int userInput = int.Parse(Console.ReadLine());

                arr[i] = userInput;
                arr[i + 1] = 0;
            }
        }

        public void PrintArray()
        {
            Console.WriteLine("Values inside the array:");
            for (int i = 0; i < arr.Length; i += 2)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }

    public class MainClass
    {
        public static void Main()
        {
            Console.Write("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());

            ArrayProcessor arrayProcessor = new ArrayProcessor(size);
            arrayProcessor.TakeUserInputs();
            arrayProcessor.PrintArray();
        }
    }
}
