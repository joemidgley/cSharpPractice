using System;

namespace events
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("In events project");

            /*
            SimpleEvent ps = new SimpleEvent();
            ps.OnThingHappened += Ps_OnThingHappened;//visual studio auto complete very helpful here.
            ps.runSimpleEvent();
            */

            EventWithCustomArgs ewc = new EventWithCustomArgs();
            ewc.OnThingHappened += Ewc_OnThingHappened;
            ewc.runEventWithCustomArgs();

            //TODO events that are NOT of type eventHandler.
            //TODO read more on what's special about events as compared to delegates. 
        }

        private static void Ewc_OnThingHappened(object sender, EventArgWithInt e)
        {
            Console.WriteLine("the int arg was:" + e.ArgInt);
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
