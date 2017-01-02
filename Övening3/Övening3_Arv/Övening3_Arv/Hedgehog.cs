namespace Övening3_Arv
{
    internal class Hedgehog : Animal
    {
        private string sound = "trrr";
        private string move = "Creep";
        private string thornSize;

        public Hedgehog()
        {

        }

        public string Sound { get; set; }
        public string Move { get; set; }
        public string ThornSize { get; set; }
    }
}