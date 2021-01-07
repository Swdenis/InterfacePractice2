using System;
namespace InterfacePractice2
{
    class Wolf : Canine
    {
        public Wolf(bool belongsToPack)
        {
            BelongsToPack = belongsToPack;
        }

        public override void MakeNoise()
        {
            if (BelongsToPack)
                Console.WriteLine("I'm in pack.");
            Console.WriteLine("Arooooo!");
        }

        public void HuntInPack()
        {
            if (BelongsToPack)
                Console.WriteLine("I'm going hunting with my pack!");
            else
                Console.WriteLine("I'm not in pack.");
        }
    }
}
