//using System;

//namespace CSharp
//{
//    class Generic_Types_and_Type_Members
//    {
//        public static void Main(string[] args)
//        {
//            bool Equal = Equals<int>.IsEquals(1, 2);
//            if (Equal)
//                Console.WriteLine("is Equal");
//            else
//                Console.WriteLine("Not Equal");
//        }
//    }
//    class Equals<T>                                       /* Generic Type are useful cause they avoid boxing
//                                                           * For example converting from object to int i.e. from class to structure
//                                                           * can cause boxing which can have a hit on performance of the program.
//                                                           */
//    {
//        public static bool IsEquals(T val1, T val2)
//        {
//            return val1.Equals(val2);
//        }
//    }
//}
