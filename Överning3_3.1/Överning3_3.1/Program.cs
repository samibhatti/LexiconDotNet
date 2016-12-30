using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Överning3_Inkapsling
{
    class Program
    {
        static void Main(string[] args)
        {
            
          //Person person = new Person();

            int age = 70;
            string fname = "Bill";
            string lname = "Gates";
            double height = 170;
            double weight = 90;

            PersonHandler personHandler = new PersonHandler();
            
            //personHandler.SetAge(person, age);

            Person person = personHandler.CreatePerson(age, fname, lname, height, weight);

            Person person1 = personHandler.CreatePerson(age, fname, lname, height, weight);

            Person person2 = personHandler.CreatePerson(age, fname, lname, height, weight);

            Person person3 = personHandler.CreatePerson(age, fname, lname, height, weight);

            Person person4 = personHandler.CreatePerson(age, fname, lname, height, weight);

            Person person5 = personHandler.CreatePerson(age, fname, lname, height, weight);

            Person person6 = personHandler.CreatePerson(age, fname, lname, height, weight);

            personHandler.PrintPerson(person);

            personHandler.PrintPerson(person1);

            personHandler.PrintPerson(person2);

            personHandler.PrintPerson(person3);

            personHandler.PrintPerson(person4);

            personHandler.PrintPerson(person5);

            personHandler.PrintPerson(person6);

        }
    }
}
