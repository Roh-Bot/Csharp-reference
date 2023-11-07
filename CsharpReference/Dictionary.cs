//using System;
//using System.Collections.Generic;
//namespace CSharp
//{
//    class Customr
//    {
//        public int Id { get; set; }
//        public string? Name { get; set; }
//        public int Payment { get; set; }

//    }
//    class CustomrProgram
//    {
//        static void Main(string[] args)
//        {
//            Customr customer1 = new Customr()
//            {
//                Id = 1,
//                Name = "Dhebug",
//                Payment = 10000000
//            };
//            Customr customer2 = new Customr()
//            {
//                Id = 2,
//                Name = "Fartix",
//                Payment = 25
//            };

//            Customr customer3 = new Customr()
//            {
//                Id = 3,
//                Name = "G",
//                Payment = 1000
//            };
//            // Basic dictionary implementation
//            Dictionary<int, Customr> customerdictionary = new Dictionary<int, Customr>();
//            customerdictionary.Add(customer1.Id, customer1);
//            customerdictionary.Add(customer2.Id, customer2);
//            customerdictionary.Add(customer3.Id, customer3);
//            Dictionary<int, Customr> dict1 = new Dictionary<int, Customr>();
//            foreach (KeyValuePair<int, Customr> i in customerdictionary)
//            {
//                Console.WriteLine("ID = {0}", i.Key);
//                Console.WriteLine("ID = {0}, Name = {1}, Payment = {2}", i.Value.Id, i.Value.Name, i.Value.Payment);
//                Console.WriteLine("-----------------------------------------------------------------");
//                //customerdictionary.ContainsKey(customer1.Id);
//            }

//            //Dictionary methods
//            // TryGetValue() -- To check whether a dictionary has a specific key

//            bool getValue = customerdictionary.TryGetValue(1, out Customr cust);
//            Console.WriteLine(getValue ? true : false);

//            //Count() -- Used to count the number of elements with or without a specific condition
//            Console.WriteLine(customerdictionary.Count(kvp => kvp.Value.Payment > 25));
//        }
//    }
//}
