//using System;


//namespace CSharp
//{
//    interface ICustomer
//    {
//        void Print();
//    }
//    interface ICustomer2 : ICustomer
//    {
//        void Print();
//    }

//    public class Implement : ICustomer2
//    {
//        void ICustomer2.Print()
//        {
//            Console.WriteLine("ICustomer2");
//        }
//        void ICustomer.Print()
//        {
//            Console.WriteLine("ICustomer1");
//        }
//    }

//    public class ProgramMain
//    {
//        public static void Main(string[] args)
//        {
//            Implement i = new Implement();
//            ((ICustomer2)i).Print();
//        }
//    }
//}
