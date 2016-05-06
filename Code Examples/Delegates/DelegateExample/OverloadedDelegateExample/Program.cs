using System;

namespace OverloadedDelegateExample
{
    public delegate void AnOverloadedDelegate(int intNum, string strVerb);

    class Program
    {
        static void Main(string[] args)
        {

            AnOverloadedDelegate delOverload = null;

            // Note, here I'm implementing a simplified event/listener design pattern
            delOverload += NotifyListenerVersionOne;
            delOverload += NotifyListenerVersionTwo;

            // Note, that the methods will be called in the order they were added.
            // So this will call NotifyListenerVersionOne then NotifyListenerVersionTwo.
            // If we had added them in the reverse order, their call order would also
            // be reversed.
            delOverload(3, "jumped");

            Console.ReadLine();

        }

        public static void NotifyListenerVersionOne(int intNum, string strVerb)
        {

            string strNotify = string.Format("It {0} {1} times!", strVerb, intNum);
            Console.WriteLine(strNotify);
            // You could then notify anyone/thing listening to version one of your project/api here!

        }

        public static void NotifyListenerVersionTwo(int intNum, string strVerb)
        {

            int intNewNum = intNum * intNum;
            string strNotify = string.Format("It {0} {1} times!", strVerb, intNewNum);
            Console.WriteLine(strNotify);
            // You could then notify anyone/thing listening to version two of your project/api here!

        }
    }
}
