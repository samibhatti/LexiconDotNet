using System;

namespace Överning3_Inkapsling
{
    internal class PersonHandler
    {
        public PersonHandler()
        {

        }

        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        public void SetFirstName(Person person, string fname)
        {
            person.FName = fname;
        }

        public void SetLastName(Person person, string lname)
        {
            person.LName = lname;
        }

        public void SetHeight(Person person, double height)
        {
            person.Height = height;

        }

        public void SetWeight(Person person, double weight)
        {
            person.Weight = weight;
        }

        public void SetPerson(Person person, int age=0, string fname="", string lname="", double height=0, double weight=0)
        {
            if (age >0) person.Age = age;
            if (fname != "") person.FName = fname;
            if (lname != "") person.LName = lname;
            if (height > 0) person.Height = height;
            if (weight > 0)  person.Weight = weight;
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
            Console.WriteLine("\n age: " + pers.Age + "\n first name: " + pers.FName + "\n last name: " + pers.LName + "\n height: " + pers.Height + "\n weight: " + pers.Weight);
        }
    }
}
