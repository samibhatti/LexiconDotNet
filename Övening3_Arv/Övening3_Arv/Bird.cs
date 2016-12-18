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
    }

    internal class Pelican : Bird
    {
        private string throatPouchSize;
        public Pelican()
        {
        }

    }

    internal class Flamingo : Bird
    {
        private string longLegsSize;

        public Flamingo()
        {
        }

    }

    internal class Swan : Bird
    {
        private string floatDistance;

        public Swan()
        {
        }

    }
}