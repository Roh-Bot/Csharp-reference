//using System.IO;
//using System;
//public class Reference      //Class for reference Parameter
//{
//    public static void referenceParam(ref int i)            //Replaces actual value in memory
//    {
//        i = 100;
//        Console.WriteLine("Reference Param:" + i);
//    }
//    public static void valueParaam(int j)               //Creates a copy of the variable and assigns new value without changing the original one
//    {
//        j = 100;
//        Console.WriteLine("Value Param:" + j);
//    }

//    public static void OutParam(int i, int j, out int Sum, out int Prod)                //Used to return multiple parameters
//    {
//        Sum = i + j;
//        Prod = i * j;
//    }

//    public static void paramsfunc(params int[] i)                //Optional array parameter, Methods cannot contain more than one parameter array
//    {                                                            // param arrays are always the last one in the parameter list of any Method
//        Console.WriteLine("There are {0} elements", i.Length);
//        foreach (int j in i)
//        {
//            Console.WriteLine(j);
//        }
//    }

//    public static void Main(string[] args)
//    {
//        int i = 0;

//        referenceParam(ref i);                          //ReferenceParam
//        Console.WriteLine("i of main method :" + i);

//        int j = 0;
//        valueParaam(j);                                 //ValueParam
//        Console.WriteLine("j of main method " + j);

//        int Sum;
//        int Prod;
//        OutParam(10, 20, out Sum, out Prod);            //OutParam
//        Console.WriteLine("Sum is {0}, Product is {1}", Sum, Prod);


//        paramsfunc();                                   //Paramsfunc
//    }
//}
