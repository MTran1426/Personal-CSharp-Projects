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
            Console.WriteLine("Hello World!");
            Console.WriteLine(word);
            Console.WriteLine(integerNumber);
            Console.WriteLine(doubleNumber);
            Console.WriteLine(character);
            Console.WriteLine(boolean);
            Console.WriteLine(integerNumber + doubleNumber);
            Console.WriteLine(word + integerNumber + doubleNumber + character + boolean);
            Console.WriteLine(maleName + " and " + femaleName + " like spending time together.");

        }
    }
}
