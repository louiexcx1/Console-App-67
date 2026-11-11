using System.Runtime.InteropServices;

namespace DataTypes9D26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variables are created with  
            // data type identifier (= value); 
            // integer 
            int num1;
            num1 = 42;
            Console.WriteLine(num1);
            int num2 = 8;
            Console.WriteLine(num2);

            // Real    
            double decimalValue = 3.147;
            double decVal = 1;
            Console.WriteLine(decVal);

            // Boolean    
            bool sunny = true;
            Console.WriteLine(sunny);

            // Character    
            char letter = 'A';
            Console.WriteLine(letter);
            char otherChar = '@';

            // String    
            string myString = "This is a a string";
            Console.WriteLine(myString);
            myString = "";

            // Concatenation
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();

            Console.WriteLine("Hello, " + firstName + " " + lastName + "!");

        }
    }
}