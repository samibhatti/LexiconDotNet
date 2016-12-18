using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
1. Skapa klassen ​Animal 
2. Fyll klassen ​Animal ​ med egenskaper (​properties) ​ som alla djur bör ha. 
3. Skapa Subklasserna (ärver från ​Animal ​ ): ​Horse ​ , ​Dog ​ , ​Hedgehog ​ , ​Worm ​ och ​Bird ​. 
4. Ge dessa minst en unik ​egenskap ​ var.
5. Skapa en lista i program.cs som tar emot djur. 
6. Skapa några djur (av olika typ) i din lista. 
7. Skriv ut vilka djur som finns i listan med hjälp av en ​foreach-loop 
8. Skapa en lista för hundar. 
9. Försök att lägga till en häst i listan av hundar. Varför fungerar inte det? Tillhöra till olika subclasses och object typ.
10. Skapa nu följande tre klasser: ​Pelican ​ , ​Flamingo ​ och ​Swan ​ . Dessa ska ärva från ​Bird. 
11. Ge dessa minst en unik egenskap var 
12. F: Vilken typ måste listan lagra för att dessa tre nya klasser ska kunna lagras tillsammans? Bird 
13. F: Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans? Animal
14. F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut, i vilken klass bör vi lägga det? Bird 
15. F: Om alla djur behöver det nya attributet, vart skulle man lägga det då? Animal */


namespace Övening3_Arv
{
    class Program
    {
        static void Main(string[] args)
        {

            Dog dog = new Dog();
            Bird bird = new Bird();
            Horse horse = new Horse();
            Hedgehog hedgehog = new Hedgehog();
            Worm worm = new Worm();

            dog.Name = "German Shephered";
            bird.Name = "Falcon";
            horse.Name = "Arabian";
            hedgehog.Name = "Spiky";
            worm.Name = "Tapeworm";

            List<Animal> animals = new List<Animal>();
            animals.Add(dog);
            animals.Add(bird);
            animals.Add(horse);
            animals.Add(hedgehog);
            animals.Add(worm);

            Console.WriteLine("List of Animals:");
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Name);

            }
            Console.WriteLine();

            Dog dog1 = new Dog();
            Dog dog2 = new Dog();
            Dog dog3 = new Dog();
            Dog dog4 = new Dog();
            Dog dog5 = new Dog();

            dog1.Name = "Bulldog";
            dog2.Name = "Poodle";
            dog3.Name = "Boxer";
            dog4.Name = "Dachshund";
            dog5.Name = "Beagle";

            List<Dog> dogs = new List<Dog>();
            dogs.Add(dog1);
            dogs.Add(dog2);
            dogs.Add(dog3);
            dogs.Add(dog4);
            dogs.Add(dog5);
            //dogs.Add(horse);

            Console.WriteLine("List of Dog types");
            foreach (var type in dogs)
            {
                Console.WriteLine(type.Name);
            }


        }
    }
}
