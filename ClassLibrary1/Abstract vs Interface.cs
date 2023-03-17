//using System;

//namespace CSharp
//{
//    public abstract class Customer          //Cannot use sealed keyword as it Contradictory. They can have access modifiers
//    {
//        private string name;                //Fields cannot be abstract
//        /* public abstract string Name         // All abstract members must be public
//         {
//             get;
//             set;
//         }*/
//        public abstract void Print();
//    }
//    public abstract class derivedCustomerAbstract : Customer, Iinterface1 { }       //Abstract class can inherit from another abstract class
//                                                                                    // and interfacesc
//    interface Iinterface1 // : Customer             //An interface can only inherit from another interface not any class or an abstract class
//    {                                               //Interfaces cannot have access modifiers
//        void Print();
//    }


//    public class Customer2 : Customer, Iinterface1      //Can implement multiple interfaces and only one abstract class at the same time
//    {
//        public override void Print()
//        {
//            Console.WriteLine("Abstract Print");
//        }
//        void Iinterface1.Print()
//        {
//            Console.WriteLine("Interface Print");
//        }
//        public static void Main(string[] args)
//        {
//            Customer c = new Customer2();
//            c.Print();
//            ((Iinterface1)c).Print();
//        }
//    }


//}