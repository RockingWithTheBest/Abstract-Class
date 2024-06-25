using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog();
            dog.MakeSound();
            Console.ReadLine();
        }
    }
    public abstract class Animal
    {
        public abstract string Name {  get; set; }
        public abstract void MakeSound();
    }
    public class Dog:Animal
    {
        public override string Name { get; set; }

        public override void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
    }
    public class Cat : Animal
    {
        public override string Name { get; set; }

        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
    }
}
