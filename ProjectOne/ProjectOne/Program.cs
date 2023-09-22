using System;

namespace ProjectOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Some word";
            int integerNumber = 1;
            double doubleNumber = 1.00;
            char character = 'A';
            bool boolean = true;
            string maleName, femaleName;
            maleName = "Jack";
            femaleName = "Jill";
            //Type-Casting
            //Implicit Type-Casting
            int typeInt = 5;
            double typeDouble = typeInt;
            //Explicit Type-Casting
            double doubleType = 6.96;
            Math.Round(doubleType);
            int intType = (int)doubleType;
            //Other method:
            double exampleDouble = 4.20;
            int exampleInt = Convert.ToInt32(exampleDouble);

            Console.WriteLine("Hello World!");
            Console.WriteLine(word);
            Console.WriteLine(integerNumber);
            Console.WriteLine(doubleNumber);
            Console.WriteLine(character);
            Console.WriteLine(boolean);
            Console.WriteLine(integerNumber + doubleNumber);
            Console.WriteLine(word + integerNumber + doubleNumber + character + boolean);
            Console.WriteLine(maleName + " and " + femaleName + " like spending time together.");
            Console.WriteLine(typeDouble);
            Console.WriteLine(intType);
            Console.WriteLine(exampleInt);
        }
    }
}
