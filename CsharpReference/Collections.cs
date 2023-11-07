//using System;
//using System.Collections.Generic;

//namespace Csharp
//{
//    class Generic<F>
//    {
//        public F? Generic1;
//        public void AddOrUpdate<U>(F data1, U data2) { }
//        public void AddOrUpdate(F data1, F data2) { }
//    }
//    class Class1
//    {
//        public string name;
//        public int id;
//        public static void Main(string[] args)
//        {
//            List<string> list = new List<string>        //Collection initializer. A simple list which can store duplicate elements.
//            {
//                "Dhebug",
//                "Fartix",
//                "G"
//            };
//            //Use list. to see through all functions
//            HashSet<string> set = new HashSet<string>()     //Cannot store duplicate elements. Used when we have only unique elements.
//            {
//                "Dhebug",
//                "Dhebug1"
//            };
//            SortedSet<string> sort = new SortedSet<string>()    //Cannot store duplicate elements. Used when sorting in ascending order.
//            {
//                "Dhebug",
//                "Fartix",
//                "G",
//                "Bran",
//                "G"
//            };
//            foreach (string s in sort)
//            {
//                Console.WriteLine(s);
//            }
//        }
//    }
//}

