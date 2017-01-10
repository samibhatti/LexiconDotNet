using System;
using System.Collections.Generic;
using System.Collections;
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
                + "\n1. Examine a List"
                + "\n2. Examine a Queue"
                + "\n3. Examine a Stack"
                + "\n4. CheckParanthesis"
                + "\n0. Exit the application");
            char input = ' '; //Creates the character input to be used with the switch-case below.
            try
            {
                input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
            }
            catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
            {
                Console.Clear();
                Console.WriteLine("Please enter some input!");
            }

            switch (input)
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

            List<string> theList = new List<string>();
            bool notExit = true;
            do
            {
                //string input = Console.ReadLine();
                char nav = ' ';
                string value = "";
                try
                {
                    Console.WriteLine("Enter input: ");
                    string input = Console.ReadLine();
                    nav = input[0];
                    value = input.Substring(1);

                }
                catch (IndexOutOfRangeException)
                {
                    Console.Clear();
                    Console.WriteLine("Please Re-Try Again: ");
                }

                switch (nav)
                {

                    case '+':
                        theList.Add(value);
                        Console.WriteLine("list count: " + theList.Count);
                        Console.WriteLine("list capacity: " + theList.Capacity);
                        break;
                    case '-':
                        theList.Remove(value);
                        Console.WriteLine("list count: " + theList.Count);
                        Console.WriteLine("list capacity: " + theList.Capacity);
                        break;
                    case '0':
                        notExit = false;
                        break;
                    default:
                        Console.WriteLine("Only '+' and '-' characters are allowed! \nEnter '0' to go to main menu ");
                        break;
                }
            }
            while (notExit);
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        /// 
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
             */

            var icaQueue = new Queue();

            bool noExit = true;
            do
            {
                Console.Write("Enter e to Enqueue or d to Dequeue or q to quit: ");
                ConsoleKeyInfo input = Console.ReadKey();
                Console.WriteLine();
                switch (input.KeyChar)
                {
                    case 'e':
                    case 'E':
                        TestQueue(icaQueue);
                        break;
                    case 'd':
                    case 'D':
                        try
                        {
                            icaQueue.Dequeue();
                            foreach (Object obj in icaQueue)
                            {
                                Console.WriteLine(obj);
                            }
                            Console.WriteLine("Queue count: " + icaQueue.Count);

                        }
                        catch (InvalidOperationException)
                        {
                            Console.WriteLine("Queue is empty");
                        }
                        break;
                    case 'q':
                    case 'Q':
                        noExit = false;
                        break;
                    default:
                        break;
                }

            } while (noExit);
        }

        static void TestQueue(Queue icaQueue)
        {
            bool exit = true;
            do
            {
                Console.Write("Enter person: ");
                string eQperson = Console.ReadLine();
                Console.WriteLine();
                if (eQperson == "")
                {
                    exit = false;
                }
                else
                {
                    icaQueue.Enqueue(eQperson);
                    Console.WriteLine("Queue count: " + icaQueue.Count);
                    foreach (Object obj in icaQueue)
                    {
                        Console.WriteLine(" {0}", obj);
                    }
                }
            } while (exit);

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

            Stack stack1 = new Stack();
            Stack stack2 = new Stack();
            bool noExit = true;

            do
            {
                Console.WriteLine("Enter:\n P to push to stack,\n O to pop from stack,\n R to reverse the stack\n q to quit");
                string value = Console.ReadLine();
                switch (value)
                {
                    case "p":
                    case "P":
                        bool exit = true;
                        do
                        {
                            Console.WriteLine();
                            Console.WriteLine("Enter item to push :");
                            string pushItem = Console.ReadLine();
                            if (pushItem == "")
                            {
                                exit = false;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Items in stack: \n");
                                stack1.Push(pushItem);
                                foreach (string item in stack1)
                                {
                                    Console.WriteLine("[" + item + "]");
                                }
                            }

                        } while (exit);
                        break;
                    case "o":
                    case "O":
                        Console.Clear();
                        Console.WriteLine("Items being popped in stack: \n");
                        try
                        {
                            stack1.Pop();
                            foreach (string item in stack1)
                            {
                                Console.WriteLine("[" + item + "]");
                            }
                        }
                        catch (InvalidOperationException)
                        {
                            Console.WriteLine("Stack is empty");
                        }
                        break;
                    case "r":
                    case "R":
                            Console.WriteLine();
                            Console.WriteLine("Enter item to string: ");
                            string stringItem = Console.ReadLine();
                            Console.Write("Items in string: " + stringItem);
                            Console.WriteLine();
                            ReverseText(stringItem, stack2);
                        break;
                    case "q":
                    case "Q":
                        noExit = false;
                        break;
                    default:
                        break;
                }

            } while (noExit);
        }

        static void ReverseText(string items, Stack stack2)
        {
            Console.Write("Items in Reversed Order using Stack: ");
            //stack2 = new Stack();

            foreach(char item in items)
            {
                stack2.Push(item);
            }
            while (stack2.Count != 0)
            {
                Console.Write(stack2.Pop());
            }
            Console.WriteLine();
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})]
             * Example of incorrect: (()]), [), {[()}]
             */

            Stack<char> stackOpeningP = new Stack<char>();
            char[] paranthesis = {'{', '[', '(', ')', ']', '}'};
            char[] openParanthesis = {'{', '[', '('};
            string charList;
            bool result = true;
            bool flag = true;
            List<char> stackList = new List<char>();
             //do
             //{
                Console.Write("Enter paranthesis: ");
                charList = Console.ReadLine();

                /*if (charList.Length % 2 != 0)
                {
                    Console.WriteLine("Not well-formed paranthesis!!");
                    Console.WriteLine();
                }
                else
                {*/
                foreach (char item in charList)
                {
                    /*if (!paranthesis.Contains(item))
                    {
                        Console.WriteLine("Re-enter, contains non-paranthesis characters");
                        Console.WriteLine();
                        Console.ReadKey();
                        return;
                    }*/
                    if (paranthesis.Contains(item))
                    {
                        stackList.Add(item);
                    }
                }
            //        flag = false;
            //    //}
            //} while (flag);

            //do {
                foreach (char item in stackList)
                {
                    if (openParanthesis.Contains(item))
                    {
                        stackOpeningP.Push(item);
                    }
                    else if (item == '}' && stackOpeningP.Count != 0)
                    {
                        char openParanA = stackOpeningP.Peek();
                        if (stackOpeningP.Pop() == '{')
                        {
                            Console.WriteLine("Well-formed paranthesis!!" + openParanA + item );
                            Console.WriteLine();
                        }
                        else {
                            Console.WriteLine("Not well-formed paranthesis!!" + openParanA + item);
                            result = false;
                        }
                    }
                    else if (item == ']' && stackOpeningP.Count != 0)
                    {
                        char openParanB = stackOpeningP.Pop();
                        if (openParanB == '[')
                        {
                            Console.WriteLine("Well-formed paranthesis!!" +openParanB + item);
                            Console.WriteLine();
                        }
                        else {
                            Console.WriteLine("Not well-formed paranthesis!!" + openParanB + item);
                            result = false;
                        }
                    }
                    else if (item == ')' && stackOpeningP.Count != 0)
                    {
                        char openParanC = stackOpeningP.Pop();
                        if (openParanC == '(')
                        {
                            Console.WriteLine("Well-formed paranthesis!!" + openParanC + item);
                            Console.WriteLine();
                        }
                        else {
                            Console.WriteLine("Not well-formed paranthesis!!" + openParanC + item);
                            result = false;
                        }
                    } else {
                        Console.WriteLine("Not well-formed paranthesis!!" + item);
                        result = false;
                    }
                    
                }

                if (result == false)
                {
                    Console.WriteLine("Final Result: Not Well-formed paranthesis");

                }
                else
                {
                    Console.WriteLine("Final Result: Well-formed paranthesis!!");

                }
            //    result = false;
            //} while (result);
            
        }
    }
}
