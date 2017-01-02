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

            PersonHandler personHandler = new PersonHandler();

            Person person1 = personHandler.CreatePerson(75, "Karin", "Eriksson", 160, 80);
            personHandler.SetAge(person1, 60);
            personHandler.PrintPerson(person1);

            Person person2 = personHandler.CreatePerson(77, "Peter", "Kol", 150, 60);
            personHandler.SetFirstName(person2, "Patrik");
            personHandler.PrintPerson(person2);

            Person person3 = personHandler.CreatePerson(80, "David", "Hammar", 177, 70);
            personHandler.SetLastName(person3, "Henrik");
            personHandler.PrintPerson(person3);

            Person person4 = personHandler.CreatePerson(50, "Kalle", "Karlsson", 160, 65);
            personHandler.SetHeight(person4, 170);
            personHandler.PrintPerson(person4);

            Person person5 = personHandler.CreatePerson(40, "Norman", "Veten", 180, 77);
            personHandler.SetWeight(person5, 80);
            personHandler.PrintPerson(person5);

            Person person6 = personHandler.CreatePerson(35, "Jin", "Ju", 170, 60);
            personHandler.SetPerson(person6, 30, "Jin", "Ju", 175, 55);
            personHandler.PrintPerson(person6);

            Person person7 = personHandler.CreatePerson(75, "Bill", "Gates", 170, 90);
            personHandler.SetPerson(person7, 85, "Bill", "Gates", weight: 95);
            personHandler.PrintPerson(person7);

        }
    }
}
