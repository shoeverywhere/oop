using System;

namespace LabActivity5
{
    class Dog : Animal
    {
        public string Breed { get; set; }
        public string Trainor { get; set; }
        public string Vaccine { get; set; }

        public override void Run()
        {
            Console.WriteLine("and barks while running.");
        }

        public override void Sleep()
        {
            Console.WriteLine(Name + " is sleeping.");
        }

        public override void MakeSound()
        {
            Console.WriteLine(Name + " barks loudly.");
        }

        public void Tricks()
        {
            Console.Write("A " + Breed + " that trained by " + Trainor + ", can do high-five ");
        }
    }
}
