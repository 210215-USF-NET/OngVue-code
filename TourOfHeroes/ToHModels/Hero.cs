using System;

namespace ToHModels
{
    public class Hero
    {
        private string heroName;

        private int hP;

        public string HeroName {
            get {
                return heroName;
            }
            set {
                if (heroName.Equals(null)) {
                    Console.WriteLine("Wrong name");
                }
            }
        }
    }
}
