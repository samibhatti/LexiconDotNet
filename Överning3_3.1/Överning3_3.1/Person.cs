using System;

namespace Överning3_Inkapsling
{
    internal class Person
    {

        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;

        public int Age
        {
            get { return age; }
        
        set
            { age = value; }
        }
    public string FName { get; set; }
    public string LName { get; set; }
    public double Height { get; set; }
    public double Weight { get; set; }


    public Person()
    {

    }
}
}