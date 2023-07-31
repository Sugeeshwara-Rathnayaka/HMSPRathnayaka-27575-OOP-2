using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac05_01
{
    public class Animal
    {
        public void PrintAnimal()
        {
            Console.WriteLine("I am an Animal.");
        }
    }

    public class Dog : Animal
    {
        public void PrintDog()
        {
            Console.WriteLine("I have four legs.");
        }
    }

    public class MainClass
    {
        public static void Main()
        {
            Animal animal = new Animal();
            Dog dog = new Dog();

            animal.PrintAnimal();
            dog.PrintDog();
            Console.ReadKey();
        }
        
    }
}
