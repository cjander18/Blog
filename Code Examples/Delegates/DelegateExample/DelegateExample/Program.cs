using System;

namespace DelegateExample
{

    public delegate void ADelegate();

    public delegate int AnIntReturnDelegate();

    public delegate void AnIntParamDelegate(int intNumber);

    class Program
    {

        public static void Main(string[] args)
        {

            // Build a vanilla delegate
            ADelegate TestADelegate = new ADelegate(DoTheThing);

            // Call a vanilla delegate
            TestADelegate();
            
            // Build a delegate that returns a value
            AnIntReturnDelegate TestAnIntReturnDelegate = new AnIntReturnDelegate(DoTheIntThing);

            // Get a return value from the delegate
            int intReturnValue = TestAnIntReturnDelegate();
            Console.WriteLine(string.Format("It returned {0}!", intReturnValue));
            
            // Build a delegate that takes a parameter
            AnIntParamDelegate TestAnIntParamDelegate = new AnIntParamDelegate(DoTheIntParamThing);

            // Pass a parameter to the delegate
            TestAnIntParamDelegate(42);

            Console.ReadLine();

        }

        public static void DoTheThing()
        {

            Console.WriteLine("It did the thing!");

        }

        public static int DoTheIntThing()
        {

            Console.WriteLine("It did the int thing!");

            return 0;

        }

        public static void DoTheIntParamThing(int intNum)
        {

            Console.WriteLine(string.Format("It did the thing {0} times!", intNum));

        }
    }
}
