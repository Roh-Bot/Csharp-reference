//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    public delegate void Print(string text);
//    class Program
//    {
//        //Method for user defined delegate
//        static void PrintForDel(string text)
//        {
//            Console.WriteLine("Hello Dhebug");
//        }

//        //Methods for Predicate
//        static bool TrueOrFalse(bool value)
//        {
//            return value;
//        }

//        static bool IsUpperCase(string str)
//        {
//            return str.Equals(str.ToUpper());
//        }

//        //Method for Func
//        static int Sum(int x, int y)
//        {
//            return x + y;
//        }

//        static void Main(string[] args)
//        {
//            // User defined delegate initialization
//            Print print1 = new Print(PrintForDel);

//            // Func delegate initialization
//            Func<int, int, int> add = new Func<int, int, int>(Sum);
//            int result = add(10, 10);
//            Console.WriteLine(result);


//            //Func<string, void> fun1 = new Func<string, void>(PrintForDel);

//            /* Func delegate must return a value. Hence, it does not accept void or no return types. The last parameter in 
//             * Func delegate is the return type
//             * uncomment the above code for demonstration
//             */



//            /*Action delegate initialization
//            * Action delegate is made exclusively for void return type methods and must contain at least one parameter.
//            */
//            Action<string> actionDelegate = new Action<string>(PrintForDel);
//            Action<string> ac = (s) => {
//                Console.WriteLine(s);
//                };

//            /*Predicate Delegate initialization
//             * It is exclusively used for returning a boolean and must contain at least one parameter
//             */
//            Predicate<string> predDele = new Predicate<string>(IsUpperCase);

//            //Shorthand for delegate initializtion
//            Predicate<string> ShorthandDele = IsUpperCase;

            

//        }
//    }
//}
