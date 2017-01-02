using System;

namespace Överning3_Inkapsling
{
    internal class PersonHandler
    {

        public PersonHandler()
        {

        }

       // private Person person;

        public void SetAge(Person pers, int age)
        {
            //age = 80;
            pers.Age = age;
            System.Console.WriteLine("inside personhandler: " + age);
        }

        public void SetPerson(Person person, int age, string fname, string lname, double height, double weight)
        {
            //Person person = new Person();
            person.Age = age;
            person.FName = fname;
            person.LName = lname;
            person.Height = height;
            person.Weight = weight;
           // System.Console.WriteLine("inside personhandler: " + age + fname + lname + height + weight);

        }

        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person person = new Person();
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