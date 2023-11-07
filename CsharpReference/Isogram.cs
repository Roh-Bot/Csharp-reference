//using System;
//using System.IO;

//namespace Dhebug
//{
//    public class Kata
//    {
//        public static bool IsIsogram(string str)
//        {
//            bool flag = false;
//            int count = 1;
//            char[] strToArray = str.ToLower().ToArray();
//            foreach (char i in strToArray)
//            {
//                for (int count1 = count; count1 < strToArray.Length; count1++)
//                {
//                    if (strToArray[count1] == i)
//                    {
//                        flag = false;
//                        break;
//                    }
//                }
//                count++;
//            }
//            return flag;
//        }
//        public static void Main(string[] args)
//        {

//            string str = "isogram";

//            char[] strToArray = str.ToArray();

//            Console.WriteLine(IsIsogram(str));
//        }
//    }
//}