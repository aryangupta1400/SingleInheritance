
// 7) Create one example for single inheritance

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple();
            apple.Display();

            Mango mango = new Mango();  
            mango.Display();

            Console.ReadKey();
        }
    }

    class Fruit
    {
        public void FruitColor(string fruitName, string color)
        {
            Console.WriteLine("The color of " + fruitName + " is " + color);
        }
    }

    class Apple : Fruit
    {
        public void Display()
        {
            Fruit fruit = new Fruit();
            fruit.FruitColor("Apple", "Red");
            
        }
    }

    class Mango : Fruit
    {
        public void Display()
        {
            Fruit fruit = new Fruit();
            fruit.FruitColor("Mango", "Yellow");

        }
    }

    
}
