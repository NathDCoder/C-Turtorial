A method is a code block that contains a series of statements. A program causes the statements to be executed by calling the method and specifying any required method arguments. In C#, every executed instruction is performed in the context of a method.

Names of Method Structure
<Access Specifier><Return Type><Method Name>(Parameter List)
{
    Method Body
}
-----------------------------------------------------
Example
public int Add(int num1, int num2) {

    int result = num1 + num2;

    return result;

}
----------------------------------------------
Shorter code
public int Add(int num1, int num2) {

      return = num1 + num2;
      
}