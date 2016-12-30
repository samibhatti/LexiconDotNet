using System;

namespace Överning3_Inkapsling
{
    internal class PersonHandler
    {

        public PersonHandler()
        {

        }

        private Person person = new Person();

        public void SetAge(Person pers, int age)
        {
            //age = 80;
            pers.Age = age;
            System.Console.WriteLine("inside personhandler: " + age);
        }

        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            person.Age = age;
            person.FName = fname;
            person.LName = lname;
            person.Height = height;
            person.Weight = weight;

            return person;
        }

        public void PrintPerson(Person pers)
        {
            Console.WriteLine("");
            Console.WriteLine("age: " + pers.Age);
            Console.WriteLine("fname: " + pers.FName);
            Console.WriteLine("lname: " + pers.LName);
            Console.WriteLine("height: " + pers.Height);
            Console.WriteLine("weight: " + pers.Weight);
        }
    }
}