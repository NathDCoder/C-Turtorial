using System;


public class Returns
{
    

    // static void Main(string[] args)
    // {
    //     //First Way of returning result
    // //    int result = Add(35, 89);
    // //    Console.WriteLine(result);
    // //    Console.Read();

    //    //Simpler Way
    //    Console.WriteLine(Add(35, 89));
    //    Console.WriteLine(Add(Add(5, 7), Add(14, 17)));
    //    Console.Read();       

    //  }

    // /*Remember the parameters will not work by themselves 
    // they need to know what datatypes they are */
    // public static int Add(int par1, int par2)
    // {
    //     return par1 + par2;
    // }

}


public class Multiplication
{
    static void Mult(string[] args)
    {
        Console.WriteLine(Multiply(5, 15));
    }

    public static int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }
}

