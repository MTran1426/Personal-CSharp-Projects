using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectThree
{
    class ModPacks
    {
        public string launcher = "curseforge";
        public string gameType = "Minecraft";
        public void gameBoot()
        {
            Console.WriteLine("Modpack launcher is: "+ launcher );
            Console.WriteLine("Game selected: "+ gameType);
        }
    }
}
