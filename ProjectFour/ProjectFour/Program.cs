using System;
using System.Media;

namespace ProjectFour
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Playing music");
            PlayMusic("C:\\Github\\Personal-CSharp-Projects\\ProjectFour\\ProjectFour\\ThenRise.wav");
        }

        public static void PlayMusic(string filePath)
        {
            SoundPlayer musicPlayer = new SoundPlayer();
            musicPlayer.SoundLocation = filePath;
            musicPlayer.PlaySync();
        }
    }
}
