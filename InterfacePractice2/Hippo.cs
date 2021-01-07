using System;
namespace InterfacePractice2
{
    class Hippo : Animal
    {
        public override void MakeNoise()
        {
            Console.WriteLine("Grunt.");    
        }

        public void Swim()
        {
            Console.WriteLine("Splach! I'm going for a swim!");
        }
    }
}
