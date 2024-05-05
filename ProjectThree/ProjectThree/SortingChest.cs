using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectThree
{
    class SortingChest
    {
        public string[] importantItems = { "Diamond", "Iron Ingot", "Lapis Lazuli" };
        public int[] itemAmount = { 5, 20, 7 };

        public void dataOutput(string[] importantItems, int[] itemAmount)
        {
            foreach (string item in importantItems)
            {
                Console.WriteLine(item);
            }

            foreach (int value in itemAmount)
            {
                Console.WriteLine(value);
            }

        }//method


    }//class SortingChest
}
