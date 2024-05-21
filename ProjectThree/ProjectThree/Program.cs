using System;
//For reading and writing files
using System.IO;

namespace ProjectThree
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reading and writing files
            string writeText = "Games are cool.";
            File.WriteAllText("filename.txt",writeText);

            string readText = File.ReadAllText("filename.txt");
            Console.WriteLine(readText);


            //Test Method
            //testMethod();

            //Parameter Method
            //int inputOne,
            //    inputTwo;

            //Console.WriteLine("Please input the first number for the addition statement: ");
            //string numberOne = Console.ReadLine();
            //Console.WriteLine("Please input the second number for the addition statement: ");
            //string numberTwo = Console.ReadLine();

            //inputOne = int.Parse(numberOne);
            //inputTwo = int.Parse(numberTwo);

            //parameterMethod(inputOne, inputTwo);

            //Default Parameter Method
            //defaultParameterMethod();
            //defaultParameterMethod("Doe"); //Input a string to change the value of the default set by parameter

            //Data Type Method
            //int answer = intMethod(1, 2);
            //Console.WriteLine("The answer is: " + answer);

            //Overload Method
            //int intAnswer = overloadMethod(1,2);
            //double doubleAnswer = overloadMethod(1.1,2.2);
            //Console.WriteLine("The integer answer is: " + intAnswer);
            //Console.WriteLine("The double answer is: "+ doubleAnswer);

            //Calling the objects from a class
            //Inventory myInventory = new Inventory();//Create a new instance of the class
            //foreach (string item in myInventory.items)//Call each element from the array in the Inventory class 
            //{
            //    Console.WriteLine(item);
            //}

            //Calling multiple objects from one class
            //Chest myChest = new Chest();//Chest is a class created separately in the same folder as the project
            //foreach (string chestItem in myChest.chestItems)
            //{
            //    Console.WriteLine(chestItem);
            //}
            //Chest myObsidianChest = new Chest();
            //foreach (string obsidianChestItem in myObsidianChest.chestItems)
            //{
            //    Console.WriteLine(obsidianChestItem);
            //}

            //SortingChest sortingChest = new SortingChest();
            //sortingChest.dataOutput(sortingChest.importantItems, sortingChest.itemAmount);

            //Calling a class with a constructor
            //Weapons weapons = new Weapons();
            //Console.WriteLine(weapons.weaponType);

            //Block block = new Block();
            //block.Name = "Dirt Block";
            //block.Type = "Common";
            //Console.WriteLine(block.Name + block.Type);

            //Mod mod = new Mod();
            //mod.gameBoot();
            //Console.WriteLine("Modpack selected is: "+ mod.modName);

            //Mobs mob = new Mobs();
            //Mobs pig = new Pig();
            //Mobs cow = new Cow();

            //mob.MobSound();
            //pig.MobSound();
            //cow.MobSound();

        }//void main

        //Basic Method
        //static void testMethod() 
        //{
        //    Console.WriteLine("This is a test method call.");
        //}

        //Method with Parameters
        //static void parameterMethod(int firstInput, int secondInput)
        //{
        //    Console.WriteLine(firstInput + " + " + secondInput + " = " + (firstInput + secondInput));
        //}

        //Method with default parameter
        //static void defaultParameterMethod(string myName = "John") 
        //{
        //    Console.WriteLine("My name is " + myName);
        //}

        //Data type method
        //static int intMethod(int x, int y)
        //{
        //    return x + y;
        //}

        //Method Overloading
        //static int overloadMethod(int x, int y)
        //{
        //    return x + y;
        //}
        //static double overloadMethod(double x, double y)
        //{
        //    return x + y;
        //}
        
    }//class program

    //Creating a class
    //public class Inventory
    //{
    //    //Objects
    //    public string[] items = {"Sword","Pickaxe","Cooked Beef","Torch"};

    //}//class Inventory

    //Inheritance class: Mod is the child, Modpacks is the parent
    //class Mod : ModPacks
    //{
    //    public string modName = "Dawncraft";
    //}
    
    //Overriding base method with virtual and override
    //class Mobs
    //{
    //    public virtual void MobSound()
    //    {
    //        Console.WriteLine("Mobs make a sound.");
    //    }
    //}

    //class Pig : Mobs 
    //{
    //    public override void MobSound()
    //    {
    //        Console.WriteLine("The pig goes oink.");
    //    }
    //}

    //class Cow : Mobs
    //{
    //    public override void MobSound()
    //    {
    //        Console.WriteLine("The cow goes moo.");
    //    }
    //}

}//namespace ProjectThree
