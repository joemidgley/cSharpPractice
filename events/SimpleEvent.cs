using System;
using System.Collections.Generic;
using System.Text;

namespace events
{
    class SimpleEvent
    {
        //events are most useful when pub and sub are NOT in the same class - thinking of unity for example.
        //publisher doesn't know about subscribers.
        public event EventHandler OnThingHappened;

        //EventHandler is in system - its a predefined delegate. 
        //events are delegates
        //events do NOT have to be eventhandler, they can be your own delegate, but usually just use eventhandler
        //events by convention, usually start with "On"

        public void runSimpleEvent()
        {
            bool thingHappened = false;
            thingHappened = true;
            if(thingHappened)
            {
                //this is an older way to check null...
                //if (OnThingHappened != null)
                //{
                //    OnThingHappened.Invoke(this, EventArgs.Empty);
                //}
                OnThingHappened?.Invoke(this, EventArgs.Empty);                
            }            
        }
    }
}
