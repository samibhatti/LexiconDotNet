using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
1. Skapa en klass ​Person​ och ge den följande privata attribut:  
 age, fName, lName, height, weight    
 Skapa publika properties med ​get ​ och ​set ​ som hämtar eller sätter tilldelad variabel. 
 Skapa en person i ​program.cs ​ , kommer du direkt åt variablerna?  
2. För att inkapsla det ytterligare skapa klassen ​PersonHandler​ 
 - en klass vars syfte är att skapa och hantera dina Person-objekt. 
 I ​PersonHandler ​ ​ skapa metoden:   public void SetAge(Person pers, int age)    
 Använd den inskickade personens​ Age property ​ för att sätta personens age-attribut inom den här metoden. 
 Istället för att enbart använda en ​property ​ har vi nu  abstraherat med två lager.  
3.I ​PersonHandler ​, skriv en metod som skapar en person med angivna värden:  
  public Person ​CreatePerson ​(int ​age ​, string ​fname ​,string ​lname ​,double ​height ​,double ​weight)   
4.Fortsätt skapa metoder i ​PersonHandler ​för att kunna hantera samtliga  operationer som man kan vilja göra med en ​Person. 
5.När denna klass är klar, kommentera bort er ​Person ​ från Program.cs, och instansiera istället en ​PersonHandler. 
Skapa därigenom några personer och testa era metoder. */


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
