﻿using System;

namespace ProjectTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Basic Example
            ////Opening Prompt
            //Console.WriteLine("Please enter your username: ");
            ////Use Console.ReadLine to read the inputted username
            //string userName = Console.ReadLine();
            ////Output will show a string and the username
            //Console.WriteLine("The username is: " + userName);

            //Input with different data types
            //Console.WriteLine("Please enter your age: ");
            //string userInputAge = Console.ReadLine();
            //int userAge = int.Parse(userInputAge);
            //Console.WriteLine("User age is " + userAge);

            //Basic Addition Input
            Console.WriteLine("Please input two numbers to be added together.");
            Console.WriteLine("First number: ");
            string firstInput = Console.ReadLine();
            Console.WriteLine("Second number: ");
            string secondInput = Console.ReadLine();
            int firstNumber = int.Parse(firstInput);
            int secondNumber = int.Parse(secondInput);
            int totalNumber = firstNumber + secondNumber;
            Console.WriteLine("The total of " + firstNumber + " + " + secondNumber + " is " + totalNumber);
            
        }
    }
}
