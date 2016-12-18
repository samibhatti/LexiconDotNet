using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*1. Skapa den abstrakta klassen ​UserError  
2. Skapa den abstrakta metoden ​UEMessage()​ som har returtypen ​string ​ . 
3. Skapa en vanlig klass ​NumericInputError  ​ som ärver från ​UserError  
4. Skriv en ​override  ​ för  ​UEMessage() ​ så att den returerar ​“You tried to use a numeric input in a text only field.This fired an error!” 
5. Skapa en vanlig klass ​TextInputError ​ som ärver från ​UserError 
6. Skriv en ​override  ​ för ​UEMessage() ​ så att den returerar​ ​ “You tried to use a text input in a numericonly field.This fired an error!”
7. I program.cs Main-metod: Skapa en lista med ​UserErrors ​ och populera den med instanser av ​NumericInputError ​ och ​TextInputError. 
8. Skriv ut samtliga UserErrors ​UEMessage() ​ genom en foreach loop. 
9. Skapa nu tre egna klasser med tre egna definitioner på ​UEMessage() 
10. Testa och se så det fungerar. 
11. F: Varför är polymorfism viktigt att behärska? 
12. F: Hur kan polymorfism förändra och förbättra kod via en bra struktur? */
namespace Övening3_Polymorfism
{
    class Program
    {
        static void Main(string[] args)
        {
            List<UserError> list = new List<UserError>();

            UserError error1 = new NumericInputError();
            list.Add(error1);

            UserError error2 = new TextInputError();
            list.Add(error2);

            UserError error3 = new LogicInputError();
            list.Add(error3);

            UserError error4 = new DateTimeError();
            list.Add(error4);

            UserError error5 = new NullError();
            list.Add(error5);

            UserError error6 = new TimeError();
            list.Add(error6);

            foreach (var error in list)
            {
                Console.WriteLine(error.UEMessage());
            }

            
            

        }
    }
}
