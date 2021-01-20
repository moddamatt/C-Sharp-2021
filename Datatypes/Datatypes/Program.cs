using System;

namespace Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Whole Numbers - int, long
            // int is sufficient for most whole numbers, 
            // the use of long is for when the numbers
            // require the use of more than 4 bytes of storage
            int num1 = 13;
            int num2 = 5;
            int sum = num1 + num2;

            Console.WriteLine("The sum is " + sum);

            // Decimals - Double, Float
            double d1 = 3.5;
            double d2 = 1.337;
            double sumD = d1 + d2;

            // When decalring a float, the usage of F is needed
            // otherwise an conversion error will happen
            float f1 = 3.5F;

            Console.WriteLine("The sum od the decimals is " + sumD);

            // Letters - char, Words - string
            char myChar = 'A';

            Console.WriteLine(myChar);

            string myString = "Hello string";

            Console.WriteLine(myString);
        }
    }
}
