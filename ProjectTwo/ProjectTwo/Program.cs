using System;

namespace ProjectTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opening Prompt
            Console.WriteLine("Please enter your username: ");
            //Use Console.ReadLine to read the inputted username
            string userName = Console.ReadLine();
            //Output will show a string and the username
            Console.WriteLine("The username is: " + userName);
        }
    }
}
