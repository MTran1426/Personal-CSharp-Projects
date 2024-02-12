using System;
using System.Linq; //Other useful array methods such as min, max and sum can be applied using system.linq

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
            //Console.WriteLine("Please input two numbers to be added together.");
            //Console.WriteLine("First number: ");
            //string firstInput = Console.ReadLine();
            //Console.WriteLine("Second number: ");
            //string secondInput = Console.ReadLine();
            //int firstNumber = int.Parse(firstInput);
            //int secondNumber = int.Parse(secondInput);
            //int totalNumber = firstNumber + secondNumber;
            //Console.WriteLine("The total of " + firstNumber + " + " + secondNumber + " is " + totalNumber);

            //Assignment Operator
            //int addition = 69;
            //addition += 1;

            //int subtraction = 69;
            //subtraction -= 1;

            //int division = 69;
            //division /= 1;

            //int multiplication = 69;
            //multiplication *= 1;

            //double modulus = 69;
            //modulus %= 3;

            //Console.WriteLine("Addition = " + addition);
            //Console.WriteLine("Subtraction = " + subtraction);
            //Console.WriteLine("Division = " + division);
            //Console.WriteLine("Multiplication = " + multiplication);
            //Console.WriteLine("Modulus = " + modulus);

            //Comparison Operators
            //Console.WriteLine("Please input a value for x : ");
            //string input = Console.ReadLine();
            //int x = int.Parse(input);
            //bool answer = false;
            //if (x == 1)
            //{
            //    answer = true;
            //    Console.WriteLine("x = 1 is : " + answer);
            //}
            //else 
            //{
            //    Console.WriteLine("x = 1 is : " + answer);
            //}

            //if (x != 1)
            //{
            //    answer = true;
            //    Console.WriteLine("x != 1 is : " + answer);
            //}
            //else
            //{
            //    Console.WriteLine("x != 1 is : " + answer);
            //}

            //if (x > 1)
            //{
            //    answer = true;
            //    Console.WriteLine("x > 1 is : " + answer);
            //}
            //else
            //{
            //    Console.WriteLine("x > 1 is : " + answer);
            //}

            //if (x < 1)
            //{
            //    answer = true;
            //    Console.WriteLine("x < 1 is : " + answer);
            //}
            //else
            //{
            //    Console.WriteLine("x < 1 is : " + answer);
            //}

            //if (x >= 1)
            //{
            //    answer = true;
            //    Console.WriteLine("x >= 1 is : " + answer);
            //}
            //else
            //{
            //    Console.WriteLine("x >= 1 is : " + answer);
            //}

            //if (x <= 1)
            //{
            //    answer = true;
            //    Console.WriteLine("x <= 1 is : " + answer);
            //}
            //else
            //{
            //    Console.WriteLine("x <= 1 is : " + answer);
            //}

            //Logical Operators
            //Console.WriteLine("Please input a value for x : ");
            //string input = Console.ReadLine();
            //Console.WriteLine("Please input a value for y : ");
            //string secondInput = Console.ReadLine();
            //int x = int.Parse(input);
            //int y = int.Parse(secondInput);
            //bool answer = false;
            //if (x == 1 && y == 2)
            //{
            //    answer = true;
            //    Console.WriteLine("x = 1 and y = 2 is : " + answer);
            //}
            //else
            //{
            //    Console.WriteLine("x = 1 and y = 2 is : " + answer);
            //}

            //if (x == 1 || y == 2)
            //{
            //    answer = true;
            //    Console.WriteLine("x = 1 or y = 2 is : " + answer);
            //}
            //else
            //{
            //    Console.WriteLine("x = 1 or y = 2 is : " + answer);
            //}

            //if (!(x == 1 && y == 2))
            //{
            //    answer = false;
            //    Console.WriteLine("x != 1 and y != 2 is : " + answer);
            //}
            //else
            //{
            //    answer = true;
            //    Console.WriteLine("x != 1 and y != 2 is : " + answer);
            //}

            //Math
            //Console.WriteLine("Input the value of x : ");
            //string input = Console.ReadLine();
            //Console.WriteLine("Input the value of y :");
            //string secondInput = Console.ReadLine();
            //int x = int.Parse(input);
            //int y = int.Parse(secondInput);
            //Console.WriteLine("The maximum value between " + x + " and " + y + " is " + Math.Max(x, y));
            //Console.WriteLine("The minimum value between " + x + " and " + y + " is " + Math.Min(x, y));
            //Console.WriteLine("The square root of " + x + " is " + Math.Sqrt(x));
            //Console.WriteLine("The absolute value of " + x + " is " + Math.Abs(x));
            //Console.WriteLine("The rounded value of " + x + " is " + Math.Round(x));

            //Strings
            //Console.WriteLine("Please input a sentence: ");
            //string input = Console.ReadLine();
            //Console.WriteLine("Your sentence is " + input.Length + " characters long."); //outputs the length of the string
            //Console.WriteLine(input.ToUpper()); //outputs all upper case
            //Console.WriteLine(input.ToLower()); //outputs all lower case

            //String Interpolation
            //string firstName = "John";
            //string lastName = "Doe";
            //string name = $"My full name is: {firstName} {lastName}";
            //Console.WriteLine(name);

            //Access Strings
            //string word = "Yeet";
            //Console.WriteLine("The first letter of " + word + " is " + word[0]);
            //Console.WriteLine("The second letter of " + word + " is " + word[1]);
            //Console.WriteLine("The index of the letter t is " + word.IndexOf("t"));

            //Switch
            //Console.WriteLine("Please input the first number value: ");
            //string inputValueOne = Console.ReadLine();
            //int valueOne = int.Parse(inputValueOne);
            //Console.WriteLine("Please input the second number value: ");
            //string inputValueTwo = Console.ReadLine();
            //int valueTwo = int.Parse(inputValueTwo);
            //Console.WriteLine("Please input an expression: ");
            //Console.WriteLine("1. Addition");
            //Console.WriteLine("2. Subtraction");
            //Console.WriteLine("3. Multiplication");
            //Console.WriteLine("4. Division");
            //string expressionInput = Console.ReadLine();
            //int expressionValue = int.Parse(expressionInput);
            //switch (expressionValue)
            //{
            //    case 1:
            //        Console.WriteLine(valueOne + " + " + valueTwo + " = " + (valueOne + valueTwo));
            //        break;
            //    case 2:
            //        Console.WriteLine(valueOne + " - " + valueTwo + " = " + (valueOne - valueTwo));
            //        break;
            //    case 3:
            //        Console.WriteLine(valueOne + " * " + valueTwo + " = " + (valueOne * valueTwo));
            //        break;
            //    case 4:
            //        Console.WriteLine(valueOne + " / " + valueTwo + " = " + (valueOne / valueTwo));
            //        break;
            //}

            //While Loop
            //int count = 0;
            //while (count <= 5) 
            //{
            //    Console.WriteLine(count);
            //    count++;
            //}

            //Do While Loop
            //int count = 0;
            //do
            //{
            //    Console.WriteLine(count);
            //    count++;
            //}
            //while (count <= 5);

            //For Loop
            //for (int count = 0; count <= 10; count++) 
            //{
            //    Console.WriteLine(count);
            //}

            //Nested For Loops
            //for (int count = 0; count <= 2; count++)
            //{
            //    Console.WriteLine(count);
            //    for (int innerCount = 0; innerCount <= 3; innerCount++)
            //    {
            //        Console.WriteLine(innerCount);
            //    }
            //}

            //Foreach Loop
            //string[] items = {"Sword", "Sheild", "Potion", "Pickaxe" };
            //foreach (string holdingItem in items)
            //{
            //    Console.WriteLine("The player is currently holding a " + holdingItem + ".");
            //}

            //Loop Break
            //string[] items = { "Sword", "Sheild", "Potion", "Pickaxe" };
            //foreach (string holdingItem in items)
            //{
            //    if (holdingItem == "Potion")
            //    {
            //        break;
            //    }
            //    Console.WriteLine("The player is currently holding a " + holdingItem + ".");
            //}

            //Arrays
            //string[] items = { "Iron Sword", "Iron Pickaxe", "Iron Shovel", "Iron Axe", "Steak", "Crafting Table" };
            ////items[2] = "Diamond Shovel"; //Acess to specific element in array
            //Console.WriteLine(items[2]);
            //Console.WriteLine(items.Length); //Shows the array length
            ////items = new string[] { "Diamond Sword" }; //Updates an existing array with the "new" keyword
            ////Console.WriteLine(items[0]);
            //Array.Sort(items);//Sorts through the array alphabetically (or in ascending order if the elements are numerical)
            //for (int count = 0; count < items.Length; count++)
            //{
            //    Console.WriteLine(items[count]);
            //}//Loops through the array

            //foreach (string count in items)
            //{
            //    Console.WriteLine(count);
            //}//Foreach loop that does the same thing

            //Multi-dimensional Arrays
            //int[,] numbers = { { 1,2,3 }, {4,5,6} };
            //Console.WriteLine(numbers[0,0]);//this accesses the first element of the first array inside the array "numbers"
            //Console.WriteLine(numbers[1,0]);//this accesses the first element of the second array inside the array "numbers"
            

        }//void main
    }//class program
}//namespace
