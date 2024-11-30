
using System;


public class Program
{

    private static void Main(string[] args)
    {
     
        const double CENTIMETERS_PER_INCH = 2.54;

       
        int number_of_inches = 5;

       
        double number_of_centimetrs = CENTIMETERS_PER_INCH * number_of_inches;

        
        Console.WriteLine("{0} inches is {1} centimeters.", number_of_inches, number_of_centimetrs);

    }
}