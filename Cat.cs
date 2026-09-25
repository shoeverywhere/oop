using System;

namespace LabActivity5
{
    class Cat : Animal
    {
        public string Breed { get; set; }

        public override void Walk()
        {
            Console.WriteLine("as it walks in the park.");
        }

        public override void Sleep()
        {
            Console.WriteLine(Name + " is sleeping.");
        }

        public override void MakeSound()
        {
            Console.Write("A " + Breed + " cat meows to other cats ");
        }

        public void Scroll()
        {
            Console.WriteLine("Cat is scrolling.");
        }
    }
}
