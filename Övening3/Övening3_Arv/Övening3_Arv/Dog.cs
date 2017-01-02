namespace Övening3_Arv
{
    internal class Dog : Animal
    {
        private string sound = "Bark";
        private string move = "Run";
        private string smellPower;

        public Dog()
        {

        }

        public string Sound { get; set; }
        public string Move { get; set; }
        public string SmellPower { get; set; }
    }

    
}