
using System;
public class Program 
{

static void Main(string[] args)
{
    Example();
    Method2("I am an argument and I am called from a method");
}

// access modifier (static) return type method name (parameter1, parameter2)
/* This method simpply writes something we tell it. It's best to create another 
 method if want to do something else.*/
public static void Example()
{
    Console.WriteLine("I am called Aquaman");
    /* Console.Read() is only read the first time so the output for the second method
    Will not be read unless Console.Read() is done away with here and moved to the main method above. */
    // Console.Read();
}
 public static void Method2(string myText) 
 {
    Console.WriteLine(myText);
    // Console.Read();
 }
}


