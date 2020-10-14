using System;

namespace events
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("In events project");
            SimpleEventSamePubSub ps = new SimpleEventSamePubSub();
            ps.OnThingHappened += Ps_OnThingHappened;//visual studio auto complete very helpful here.
            ps.runSimpleEvent();

            //TODO events across different classes.
            //TODO events with custom eventArgs
            //TODO events that are NOT of type eventHandler.
            //TODO read more on what's special about events as compared to delegates. 
        }

        private static void Ps_OnThingHappened(object sender, EventArgs e)
        {
            //this function was auto created with the below error by VS for me. 
            //throw new NotImplementedException();

            //typing ps.OnThingHappened += prompted me with a TAB to auto complete. 

            Console.WriteLine("The thing happened!");
            Console.WriteLine("sender was:" + sender.ToString());

        }
    }
}
