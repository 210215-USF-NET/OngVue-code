using System;

namespace ToHUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero newHero = new Hero();
            Console.WriteLine("Enter Hero Name: ");
            newHero.HeroName = Console.ReadLine();
        
        }
    }
}
