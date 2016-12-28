using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EmployeeDirectory
{
    class Directory
    {
        private Employee[] employees;
        private int count;

        public Directory(int size)
        {
            employees = new Employee[size];
        }

        public Employee[] ListAll()
        {
            int count = 0;

            foreach (Employee employee in employees)
            {
                if (employee != null) count += 1;
            }

            Employee[] copy = new Employee[count];

            int index = 0;

            foreach (Employee employee in employees)
            {
                if (employee != null)
                {
                    copy[index] = employee;

                    index += 1;
                }
            }

            // return employees.ToArray();
            return copy;
        }

        public void Add(Employee employee)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i] == null)
                {
                    employees[i] = employee;
                    break;
                }
            }
        }

        public Employee Remove(Employee employee)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i] == employee)
                {
                    employees[i] = null;
                    count -= 1;
                    // break;
                    return employee;
                }
            }

            return null;
        }

        public Employee[] Find(string name)
        {
            foreach (var employee in employees)
            {
                if (employee?.Name == name)
                {
                    count += 1;
                }
            }

            var result = new Employee[count];
            count = 0;
            foreach (var employee in employees)
            {
                if (employee?.Name == name)
                {
                    result[count] = employee;
                    count += 1;
                }
            }

            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDirectory
{
    class Employee
    {
        private string name;
        //public int Salary;

        public string Name
        {
            get { return name; }

            set { if (!string.IsNullOrWhiteSpace(value)) name = value; }
        }

        /*       public void SetName(string name)
               {
                   if (string.IsNullOrWhiteSpace(name)) return;
                   this.name = name;
               }*/

        /* public bool SetName(string name)
         {
             if (string.IsNullOrWhiteSpace(name)) return false;
             this.name = name;
             return true;
         }*/

        private int salary;

        public int Salary
        {
            get { return salary; }
            set { if (value >= 0) salary = value; }
        }

        /*  private DateTime startDate;
          public DateTime StartDate
          {
              get { return startDate; }
              set { startDate = value; }
          }*/


        public DateTime StartDate { get; set; }

        public Employee(string name)
        {
            Name = name;
            Salary = 0;
            StartDate = DateTime.Today;
        }

        /* public Employee(string name): this(name, 0)
         {

         }*/

        public Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;
            StartDate = DateTime.Today;
        }

        /*public int DaysEmployed()
        {
           get {

                DateTime today = DateTime.Today;
                DateTime employed = StartDate;

                TimeSpan employedTime = today - employed;

                int numberOfDays = (int)
                    employedTime.TotalDays;
                return numberOfDays;
            }

            set 
            {
                StartDate = DateTime.Today.AddDays(-Value);
            }

        }*/

        public int DaysEmployed
        {
            get { return (int)(DateTime.Today - StartDate).TotalDays; }
            set { StartDate = DateTime.Today.AddDays(-value); }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDirectory
{
    class Program
    {
        static void Main(string[] args)
        {

            int directorySize = 2;
            Employee[] employees = new Employee[directorySize];

            Directory directory = new Directory(directorySize); //added Directory class

            bool doItAgain = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Välkommen till personalregistret!");
                Console.WriteLine();
                Console.WriteLine("M. Mata in uppgifter");
                Console.WriteLine("V. Visa personallistan");
                Console.WriteLine("Q. Avsluta");

                string selection = AskForString("> ").ToUpper();
                Console.Clear();
                switch (selection) //(selection.ToUpper())
                {
                    case "M":
                        Console.WriteLine("Ange dina anställdas uppgifter:");
                        AddEmployees(directory);
                        break;
                    case "V":
                        Console.WriteLine("Personalregistret innehåller följande personer:");
                        FindEmployee(directory);
                        break;
                    case "S":
                        Console.WriteLine("Search:");
                        ListEmployees(directory);
                        break;
                    case "Q":
                        doItAgain = false;
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Tryck på any key för att visa listan");
                Console.ReadKey();
            } while (doItAgain);

        }


        private static void ListEmployees(Directory directory)
        {

            foreach (Employee employee in directory.ListAll())   //added Directory class
            {
                Console.WriteLine();
                Console.WriteLine("Namn: " + employee.Name);
                Console.WriteLine("Lön: " + employee.Salary + " kr");
                Console.WriteLine("Start: " + employee.StartDate);
                Console.WriteLine("Dagar: " + employee.DaysEmployed);
            }
        }

        private static void FindEmployee(Directory directory)
        {
            var query = AskForString("Ange namn på personen: ");

            var result = directory.Find(query);

            foreach (Employee employee in directory.ListAll())   //added Directory class
            {
                Console.WriteLine();
                Console.WriteLine("Namn: " + employee.Name);
                Console.WriteLine("Lön: " + employee.Salary + " kr");
                Console.WriteLine("Start: " + employee.StartDate);
                Console.WriteLine("Dagar: " + employee.DaysEmployed);
            }
        }

        //private static void AddEmployees(int directorySize, Employee[] employees)
        //private static void AddEmployees(Employee[] employees)
        private static void AddEmployees(Directory directory)
        {
            //int directorySize = employees.Length;
            //int counter = 0;
            while (true)
            {
                Console.WriteLine();
                string name = AskForString("Ange namn: ");
                if (name == "") break;

                int salary = AskForInt("Ange lön: ");
                int days = AskForInt("Hur många dagar dagar " + name + " varit anställd ?");
                directory.Add(new Employee(name, salary) //added for directory class
                {
                    DaysEmployed = days
                });

            }
        }

        private static int AskForInt(string question)
        {
            int value;
            bool parsed;
            string error = "";
            do
            {
                string input = AskForString(question + error);
                parsed = int.TryParse(input, out value);
                error = "error";
            } while (!parsed); //(parsed == false)

            return value;
        }

        private static string AskForString(string question)
        {
            Console.Write(question);
            return Console.ReadLine();
            /* string name = Console.ReadLine();
             return name;*/
        }
    }
}

/*            int counter = -1;
             foreach (Employee employee in employees)
             {
               counter = counter + 1;
               if (employee != null) continue;

                string name = AskForString("Ange namn: ");
                if (name == "") break;

                int salary = AskForInt("Ange lön: ");
                int days = AskForInt("Hur många dagar dagar " + name + " varit anställd ?");

                employees[counter] = new Employee() {
                    Salary = salary,
                    Name = name,
                    StartDate = DateTime.Today
                };

                directory.Add(new Employee(name, salary) //added for directory class
                {
                    DaysEmployed = days
                });   
                
                employees[counter] = new Employee(name, salary)
                {
                    DaysEmployed = days
                    StartDate = DateTime.Today.AddDays(1)
                };

             }*/

/*do
{

    string name = AskForString("Ange namn: ");

    if (name == "") break;
    int salary = AskForInt("Lön: ");

    employees[counter] = new Employee(name, salary);
    counter = counter + 1;

} while (counter < directorySize);*/
// cleanup: return;
// }
// int counter = 0;
//Console.WriteLine("Ange namn: ");          
//if (name == "") goto cleanup;
// if (name == "") return;
/*{
    break;
}*/
// markera for refactor
//string question = "Lön: ";

/* employees[counter] = new Employee()
 {
     Name = name,
     Salary = salary

 };*/

// employees[counter].SetName(name); //added

//employees[counter] = temp;

/* private static int AskForInt(string question)
 {
     string salaryString = AskForString(question);
     int salary;
     int.TryParse(salaryString, out salary);
     return salary;
 }*/

/* private static int AskForInt(string question)
 {
     string input = AskForString(question);
     int salary;
     int.TryParse(input, out salary);
     return salary;
 }*/

//AddEmployees(directory);

//while (counter < 2);


/*foreach (Employee employee in employees)
{
     Employee employee1 = new Employee();
     employee1.Name = "Agneta";
     employee1.Salary = 20000;

//Console.WriteLine(employee1.GetType());
if (employee == null) break;
Console.WriteLine("Namn: " + employee.Name);
Console.WriteLine("Lön: " + employee.Salary + " kr");
} */
/*
int counter = 0;
do
{
    // int counter = 0;
    //Console.WriteLine("Ange namn: ");          
    string name = AskForString("Ange namn: ");

    if (name == "") break;

    {
        break;
    }
// markera for refactor
//string question = "Lön: ";
int salary = AskForInt("Lön: ");

employees[counter] = new Employee()
{
    Name = name,
    Salary = salary

};

//employees[counter] = temp;
counter = counter + 1; */

//private static void ListEmployees(Employee[] employees)
// foreach (Employee employee in employees)
// {
/* Employee employee1 = new Employee();
 employee1.Name = "Agneta";
 employee1.Salary = 20000;
 */
//Console.WriteLine(employee1.GetType());
/*   if (employee == null) break;
   Console.WriteLine();
   Console.WriteLine("Namn: " + employee.Name);
   Console.WriteLine("Lön: " + employee.Salary + " kr");
   Console.WriteLine("Start: " + employee.StartDate);
   Console.WriteLine("Dagar: " + employee.DaysEmployed);*/
// }


