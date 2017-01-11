using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>
            {
                new Person() { Id = 1, Name = "Alexandra", Birthday = DateTime.Parse("1989-09-12") },
                new Person() { Id = 2, Name = "Bertil", Birthday = DateTime.Parse("1989-09-22") },
                new Person() { Id = 3, Name = "Calle", Birthday = DateTime.Parse("1989-09-02") },
                new Person() { Id = 4, Name = "Denise", Birthday = DateTime.Parse("1999-09-02") }

            };

            var cars = new List<Car>
            {
                new Car { Brand = "Volvo", MaxSpeed = 120, OwnerId = 2 },
                new Car { Brand = "Porsche", MaxSpeed = 220, OwnerId = 1 },
                new Car { Brand = "Tesla", MaxSpeed = 180, OwnerId = 2 },
                new Car { Brand = "Corvette", MaxSpeed = 320, OwnerId = 2 }

            };

            var sportsCars = cars.Where(c => c.MaxSpeed > 200);
            var sportsCarsBrands = sportsCars.Select(c => c.Brand);

            Console.WriteLine("SportsCars: ");
            /*foreach (var item in sportsCars)
            {
                Console.WriteLine("["+item.Brand+"]");
            }*/
            foreach (var item in sportsCarsBrands)
            {
                Console.WriteLine("[" + item + "]");
            }

            var ages = people
                .Select(p => new
                {
                    Name = p.Name,
                    Age = (int)(DateTime.Today - p.Birthday).TotalDays / 365 //add int to cast
                });
            foreach (var item in ages)
            {
                Console.WriteLine($"{ item.Name} is { item.Age} years old.");
            }

            var owners = people
                .GroupJoin(cars, p => p.Id, c => c.OwnerId, (p, ownedCars) => new
                {
                    Owner = p,
                    Cars = ownedCars
                
                });

            Console.WriteLine("Owners and their cars");
            foreach (var ownership in owners)
            {
                var owner = ownership.Owner;
                Console.WriteLine($"{owner.Name}: ");
                foreach (var car in ownership.Cars)
                {
                    Console.WriteLine($"   {car.Brand} \t(max speed: {car.MaxSpeed} mph)");
                }
            }

            var ownerships = people
                .GroupJoin(cars, p => p.Id, c => c.OwnerId, (person, ownedCars) => new
                {
                    Owner = person,
                    Cars = ownedCars

                });
//                .Where(object =>)

            Console.WriteLine("Owners and their cars");
            foreach (var ownership in owners)
            {
                var owner = ownership.Owner;
                Console.WriteLine($"{owner.Name}: ");
                foreach (var car in ownership.Cars)
                {
                    Console.WriteLine($"   {car.Brand} \t(max speed: {car.MaxSpeed} mph)");
                }
            }
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
    }

    class Car
    {
        public string Brand { get; set; }
        public int MaxSpeed { get; set; }
        public int OwnerId { get; set; }
    }
}
