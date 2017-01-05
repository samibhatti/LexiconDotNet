using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {
            Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                +"\n1. Examine a List"
                +"\n2. Examine a Queue"
                +"\n3. Examine a Stack"
                +"\n4. CheckParanthesis"
                +"\n0. Exit the application");
            char input = ' '; //Creates the character input to be used with the switch-case below.
            try
            {
                input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
            }
            catch(IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
            {
                Console.Clear();
                Console.WriteLine("Please enter some input!");
            }
            
            switch(input)
            {
                case '1':
                    ExamineList();
                    break;
                case '2':
                    ExamineQueue();
                    break;
                case '3':
                    ExamineStack();
                    break;
                case '4':
                    CheckParanthesis();
                    break;
                case '0':
                    return;
                default:
                    Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                    break;
            }
            Main();
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            bool exit = true; 
            do
            {

                List<string> theList = new List<string>();
                //var theList = new List<string>();
                //string input = Console.ReadLine();
                // char nav = input[0];
                // string value = input.substring(1);
                // string value = input.Substring(1);
                Console.WriteLine("Enter input: ");
                string input = Console.ReadLine();
                char nav = input[0];
                //nav = char.TryParse(Console.ReadLine(), out nav1);

                switch (nav)
                {

                    case '+':
                        //for (int i = 0; i < 10; i++)
                        bool input2 = true;
                        do
                        {
                            Console.WriteLine("Enter a input to list");
                            string input1 = Console.ReadLine();
                          /*  if (input1 = "")
                            {
                                input2 = false;
                            }*/
                            
                            
                                theList.Add(input1);
                                Console.WriteLine("list count: " + theList.Count);
                                Console.WriteLine("list capacity: " + theList.Capacity);
                            
                        } while (input2);
                        break;
                    case '-':
                        bool input3 = true;
                        do
                        {
                            Console.WriteLine("remove a input from list");
                            string input4 = Console.ReadLine();
                            if (input4 = "")
                            {
                                input3 = false;
                            }
                            theList.Remove(input4);
                            Console.WriteLine("list count: " + theList.Count);
                            Console.WriteLine("list capacity: " + theList.Capacity);

                        } while (input3);
                        break;
                    default:
                        
                        Console.WriteLine("fail entered, retry again: "); ;
                        exit = false;    
                        break;
                }
                //Console.ReadKey();
            }
            while (exit);
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})]
             * Example of incorrect: (()]), [), {[()}]
             */
        }
    }
}
