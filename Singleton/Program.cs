using System;

namespace Singleton
{
    class MapGame
    {
        static void Main(string[] args)
        {
            Ninja mainCharacterMap1 = Ninja.GetInstance();
            Ninja mainCharacterMap2 = Ninja.GetInstance();
            if(mainCharacterMap1==mainCharacterMap2)
            {
                Console.WriteLine("Ninja is singleton");
            }
        }
    }
}
