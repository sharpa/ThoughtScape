using System;

namespace ThoughtScape
{
    class ConsoleCentralController : CentralController
    {
        private bool VarShouldContinue = true;

        public override void OfferMenu()
        {
            while (this.ShouldContinue())
            {
                Console.WriteLine("WHAT WOULD YOU LIKE TO DO?\n\t1. CREATE A NEW NOTE\n\t2. QUIT");
                string InputOption = Console.ReadLine();
                if ("1".Equals(InputOption)) {
                    Console.WriteLine("UNFORTUNATELY, THAT OPTION IS NOT YET IMPLEMENTED.");
                }
                else if ("2".Equals(InputOption)) {
                    this.SetShouldContinue(false);
                }
                else {
                    Console.WriteLine("THAT IS NOT A VALID OPTION: {0}", InputOption);
                }
            }
        }

        private bool ShouldContinue()
        {
            return this.VarShouldContinue;
        }
        private void SetShouldContinue(bool ShouldContinue)
        {
            this.VarShouldContinue = ShouldContinue;
        }
    }
}
