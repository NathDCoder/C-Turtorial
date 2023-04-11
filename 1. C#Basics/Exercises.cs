
using System;

///<summary>
/// You must comment in each exercise to run them. It must be one exercise at a time.
///<summary>

// Exercise 1
// public class MyFirstApp
// {
//     public static void Main()
//     {

//         int a = 1;
//         int b = 2;

//         int c = a + b;
//         Console.WriteLine(c);
//     }
// }



//Exercise 2
// public class MyFirstApp
// {
//     public static void Main()
//     {
//         //You can change the value of an integer 
//         int a = 1;
//         int b = 2;

//         a = 5;

//         int c = a + b;
//         Console.WriteLine(c);
//     }
// }



// Exercise 3
// public class MyFirstApp
// {
//     public static void Main()
//     {
//         //You can change the value of a string too
//        string username = "Black Adam";

//        username = "Superman";


//        Console.WriteLine(username);
//     }
// }



//Exercise 4
public class MyFirstApp
{
    public static void Main()
    {
     
       float vat = 15f;
       float prodA = 6.52f;
       float prodB = 2.69f;
       float prodC = 7.25f;

       float summed = prodA + prodB + prodC;
       float totalTax = (summed / 100) * vat;

        //summed = summed + totalTax;
       summed += totalTax;

        Console.WriteLine("Total price is " + summed);
    }
}

