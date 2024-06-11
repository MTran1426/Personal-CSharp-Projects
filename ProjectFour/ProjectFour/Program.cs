using System;
using System.IO;
using System.Media;

namespace ProjectFour
{
    class Program
    {
        static void Main(string[] args)
        {
            bool powerOn = true;
            string userInput;
            string playerInput;


            while (powerOn == true)
            {

                Console.WriteLine("Wav file music player");
                Console.WriteLine("1. Play music");
                Console.WriteLine("2. Exit");
                userInput = Console.ReadLine();

                int menuOption = int.Parse(userInput);

                switch (menuOption)
                {
                    case 1:

                        Console.WriteLine("Press P to play");
                        Console.WriteLine("Press S to stop");
                        playerInput = Console.ReadLine();

                        SoundPlayer musicPlayer = new SoundPlayer();
                        if (playerInput == "p")
                        {
                            musicPlayer.SoundLocation = "C:\\Github\\Personal-CSharp-Projects\\ProjectFour\\ProjectFour\\ThenRise.wav";
                            musicPlayer.Play();
                        }
                        else if (playerInput == "s")
                        {
                            musicPlayer.Stop();
                        }

                        break;

                    case 2:
                        powerOn = false;
                        break;
                }

            }

            //Console.WriteLine("Playing music");
            //PlayMusic("C:\\Github\\Personal-CSharp-Projects\\ProjectFour\\ProjectFour\\ThenRise.wav");
        }

        //public static void PlayMusic(string filePath)
        //{
        //    SoundPlayer musicPlayer = new SoundPlayer();
        //    musicPlayer.SoundLocation = filePath;
        //    musicPlayer.PlaySync();
        //}
    }
}
