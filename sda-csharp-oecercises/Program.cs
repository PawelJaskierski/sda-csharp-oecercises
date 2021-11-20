using System;
using System.Collections.Generic;

namespace sda_csharp_oecercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            Cat c1 = new Cat("c1");
            c1.MakeSound();
            Dog d1 = new Dog("d1");
            d1.MakeSound();
            animals.Add(c1);
            animals.Add(d1);

            foreach (Animal a in animals) {
                a.MakeSound();
                if (a is Cat){
                    Console.WriteLine("Cat");
                }
                else if (a is Dog) {
                    Console.WriteLine("Dog");
                }
            }
        }
    }
}
