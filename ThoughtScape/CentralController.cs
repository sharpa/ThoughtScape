using System;
using System.IO;
using System.Diagnostics;

namespace ThoughtScape
{
    abstract class CentralController
    {
        protected static TraceSource Logger;

        private static void InitializeLogger()
        {
            StreamWriter Writer = new StreamWriter("Info.log");
            TextWriterTraceListener TextListener = new TextWriterTraceListener(Writer);
            CentralController.Logger = new TraceSource("logger");
            CentralController.Logger.Switch.Level = SourceLevels.All;
            System.Collections.IList Listeners = CentralController.Logger.Listeners;
            Listeners.Add(TextListener);
        }

        public static void Main()
        {
            CentralController.InitializeLogger();


            CentralController Controller = new ConsoleCentralController();
            Controller.OfferMenu();


            Logger.TraceInformation("Running Complete");
            CentralController.Logger.Close();
            Console.WriteLine("\n\n\nRunning complete.  Press any key to continue...");
            Console.ReadKey();
        }

        public abstract void OfferMenu();
    }
}

