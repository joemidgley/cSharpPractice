using System;
using System.Collections.Generic;
using System.Text;

namespace delegates
{
    class someDelegates
    {
        delegate void PrintThing();
        delegate int Sum(int a, int b);
        delegate string Concat(string a, string b);

        //delegate keyword can do different things depending on context. it can create a delegate type, or it can create an anonymous method. 
        //"delegate" when people say it can usually mean delegate type or delegate instance. 
        //there are some predefined delegates that are good to know - EventHandler, Func, Action...
        //the microsoft documentation on this stuff is excellent btw
                        
        public void runSomeDelegates()
        {
            Console.WriteLine("run some delegates");
            PrintThing pt1;
            PrintThing pt2;
            PrintThing pt3;

            pt1 = new PrintThing(Thing1);//old school way of making a delegate instance, I don't think anyone does this anymore. 
            pt1();
            pt1.Invoke();//another way to call. 

            pt2 = Thing2;
            pt2.Invoke();

            Sum sum1;
            sum1 = add;

            int total = sum1(1, 2);
            Console.WriteLine("sum" + total);

            pt3 = delegate () { Console.WriteLine("I'm an anonymous function");};
            pt3();

            Concat cc1;
            cc1 = delegate (string a, string b) { return a + b; };

            string result = cc1("pumpkin", "pie");
            Console.WriteLine("result from anonymous function call with 2 parameters and a return type: " + result);
            //Note - lambdas have largely made anonymous methods obsolete. But good to know about in case I run into any. 
            //c# in depth had like one example of something an anonymous function can do that a lambda can't, but it didn't look useful. 

        }

        public int add(int i, int j)
        {
            return i + j;
        }


        public void Thing1()
        {
            Console.WriteLine("Thing1");
        }

        public void Thing2()
        {
            Console.WriteLine("Thing2");
        }


    }
}
