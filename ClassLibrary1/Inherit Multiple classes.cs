//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    interface IInterface1
//    {
//        void Print();
//    }
//    public class Class1 : IInterface1                   //Inheriting Interface1 
//    {
//        public void Print()A
//        {
//            Console.WriteLine("Class1 Print");
//        }
//}
//interface IInterface2
//{
//    void Print();
//}
//public class Class2 : IInterface1                   //Inheriting Interface2              
//{
//    public void Print()
//    {
//        Console.WriteLine("Class2 Print");
//    }
//}



//public class Class3 : IInterface1, IInterface2          //Inheriting Both Interfaces
//{                                                       /* As Both Interfaces have their methods implemented in their respective derived classes
//                                                             * indirectly we are inheriting the classes and using their members*/
//    Class1 c1 = new Class1();
//    Class2 c2 = new Class2();
//    public void Print()
//    {
//        c1.Print();
//    }
//    void IInterface2.Print()
//    {
//        c2.Print();
//    }

//    public static void Main(String[] args)
//    {
//        Class3 c3 = new Class3();
//        c3.Print();
//        ((IInterface2)c3).Print();
//    }

//}
    
//}
