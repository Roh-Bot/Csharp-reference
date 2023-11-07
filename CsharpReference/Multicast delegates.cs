//using System;

//namespace Csharp1
//{
//    delegate void Provoke1();
//    public class Geru
//    {

//        public static void Provoke()
//        {
//            Console.WriteLine("1");
//        }
//        public static void Provoke2()
//        {
//            Console.WriteLine("2");
//        }
//        public static void Provoke3()
//        {
//            Console.WriteLine("3");
//        }
//        public static void Provoke4()
//        {
//            Console.WriteLine("4");
//        }
//        public static void Main(string[] args)
//        {
//            Provoke1 p = new Provoke1(Provoke);
//            Provoke1 p2, p3, p4, p5;
//            //p2 = new Provoke1(Provoke2);
//            //p3 = new Provoke1(Provoke3);
//            //p4 = new Provoke1(Provoke4);
//            //p5 = p2 + p3 + p4;
//            //p5();
//            p += Provoke2;                  
//            p();

//        }
//    }

//}