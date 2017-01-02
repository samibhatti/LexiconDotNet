namespace Övening3_Arv
{
    internal class Bird : Animal
    {

        private string move = "fly";
        private string flightHeight;
        private string sound;
        public Bird()
        {
            
        }

        public string Move { get; set; }
        public string FlightHeight { get; set; }
        public string Sound { get; set; }

    }

    internal class Pelican : Bird
    {
        private string throatPouchSize;
        public Pelican()
        {
        }

        public string ThroatPouchSize { get; set; }

    }

    internal class Flamingo : Bird
    {
        private string longLegsSize;

        public Flamingo()
        {
        }

        public string LongLegsSize{ get; set; }

    }

    internal class Swan : Bird
    {
        private string floatDistance;

        public Swan()
        {
        }

        public string FloatDistance { get; set; }

    }
}