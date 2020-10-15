using System;
using System.Collections.Generic;
using System.Text;

namespace events
{
    //example with custom event arg. 
    public class EventArgWithInt: System.EventArgs
    {
        public int ArgInt;

        public EventArgWithInt(int i)
        {
            ArgInt = i;
        }
    }

    class EventWithCustomArgs
    {
        //EventHandler with generics for a different custom eventArg.       
        public event EventHandler<EventArgWithInt> OnThingHappened;

        public void runEventWithCustomArgs()
        {
            bool doEvent = false;
            doEvent = true;
            if(doEvent)
            {
                OnThingHappened?.Invoke(this, new EventArgWithInt(42));
            }
        }


    }
}
