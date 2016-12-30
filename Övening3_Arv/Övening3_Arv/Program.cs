using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övening3_Arv
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal animal = new Animal();

            Dog dog = new Dog();
            Bird bird = new Bird();
            bird.Name = "falcon";

            //Animal animal = new Animal();

            List<Animal> animals = new List<Animal>();

            animals.Add(bird);
            animals.Add(dog);

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Name);
            }

        }
    }
}
