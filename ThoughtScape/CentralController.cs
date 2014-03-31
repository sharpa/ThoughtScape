using System;

namespace ThoughtScape
{
    abstract class CentralController
    {
        public static void Main()
        {
            CentralController controller = new ConsoleCentralController();
            controller.OfferMenu();
        }

        public abstract void OfferMenu();
    }
}

