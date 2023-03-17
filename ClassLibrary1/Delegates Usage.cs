//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace ConsoleApplication2
//{
//    class Delegate
//    {
//        public static void Main()
//        {
//            List<Employee> emplist = new List<Employee>();
//            emplist.Add(new Employee() { ID = 101, Name = "Dhebug", Salary = 5000, Experience = 99999999 });
//            emplist.Add(new Employee() { ID = 102, Name = "Geru", Salary = 6000, Experience = -25 });
//            emplist.Add(new Employee() { ID = 103, Name = "Kaeshit", Salary = 7000, Experience = 2 });
//            emplist.Add(new Employee() { ID = 104, Name = "Bran", Salary = 4000, Experience = 1 });
//            emplist.Add(new Employee() { ID = 105, Name = "Fart", Salary = 4500, Experience = 0 });
//            IsPromotable del = new IsPromotable(Promote);
//            Employee.PromoteEmployee(emplist, del);
//        }
//        public static bool Promote(Employee emp)
//        {
//            if (emp.Experience >= 5)
//            {
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }
//    }
//    internal delegate bool IsPromotable(Employee empl);
//    class Employee
//    {
        
//        public int ID { get; set; }
//        public string Name { get; set; }
//        public int Salary { get; set; }
//        public int Experience { get; set; }

//        public static void PromoteEmployee(List<Employee> emplist, IsPromotable ispromotable)
//        {
//            foreach (Employee employee in emplist)
//            {
//                if (ispromotable(employee))
//                {
//                    Console.WriteLine(employee.Name + " is promoted");
//                }
//            }
//        }
//    }
//}