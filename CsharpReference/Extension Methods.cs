//using System;
//using System.Linq;

//namespace CSharp
//{
//    public class Program3
//    {
//        public static void Main(string[] args)
//        {
//            string str = "hello";
//            Console.WriteLine(str.ConverToUpper());
//            Console.WriteLine(StringHelper.ConverToUpper(str));
//            List<string> list = new List<string>();
//        }
//    }
//    public static class StringHelper
//    {
//        public static string ConverToUpper(this string str)
//        {
//            return str.ToUpper();
//        }
//    }
//}

////An extension method must be defined in a top-level static class.
////An extension method with the same name and signature as an instance method will not be called.
////Extension methods cannot be used to override existing methods.
////The concept of extension methods cannot be applied to fields, properties or events.
////Overuse of extension methods is not a good style of programming.
