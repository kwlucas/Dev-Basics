using System;

//C sharp is an object orientated programming (OOP) language.
//Object orientated means that there is a focus on having "Objects" that contain code.
//C# is a type of OOP that is class based. All that means is that its "Objects" are called a Class
//So in a C# Script you must enclose your code in a class.
public class cSharpDataTypes //Public means that this class and its code can be accessed by other scripts
{
    //Data types - C# is an implicity typed language all that means is you need to state what kind of data a variable is.
    private string text = "Sample Text";
    //Bool is short for boolean. It means true or false.
    private bool yesNo = true;
    private int number = 3;
    private float floatNumber = 3.141592f;
    private double doubleNumber = 3.14159265359d;
    //Floats and doubles are similar, but basically data of course has "size"
    //Think of the size as the number of characters in something 1.1 has 2 digits. 1.01 has 3 digits.
    //A float is limited to a size (32 bits) and a double has a limit that is double that (64 bits)
    void fillerMethod()
    {
        Console.Write(text);
        Console.Write(yesNo);
        Console.Write(number);
        Console.Write(floatNumber);
        Console.Write(doubleNumber);
        
    }


}