//using System;


//namespace CSharp
//{
//    public class Employee             //sealed keyword
//    {
//        public virtual void PrintName()
//        {
//            Console.WriteLine("Employee");
//        }
//        public void PrintName2()
//        {
//            Console.WriteLine("Print Name 2");
//        }

//    }

//    public class PartTimeEmployee : Employee
//    {
//        public string s;
//        public new void PrintName()
//        {
//            base.PrintName();
//        }
//        public void CallFunction()
//        {
//            Console.WriteLine("callFunc");
//        }
//    }

//    public class MethodHiding : Employee
//    {
//        public static void Main(string[] args)
//        {
//            PartTimeEmployee pte = new PartTimeEmployee(); // Default Call
//            ((Employee)pte).PrintName();                    //Type casting to call the Hidden method of Employee class

//            Employee pte2 = new PartTimeEmployee();         // creating an object of type Employee and calling the PTE constructor
//            pte2.PrintName();                               // Now we can all the members of both the classes with a single object 
//            pte.CallFunction();

//            Employee pte3;
//            pte3 = pte2;


//            pte3.PrintName2();
//        }
//    }
//}
