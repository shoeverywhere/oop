using System;

namespace LabActivity5
{
    class Dog : Animal
    {
        public string Breed { get; set; }[cite: 2]
        public string Trainor { get; set; }[cite: 2]
        public string Vaccine { get; set; }[cite: 2]

        public override void Run()
        {
            Console.WriteLine("and barks while running.");[cite: 1]
        }

        public override void Sleep()
        {
            Console.WriteLine(Name + " is sleeping.");[cite: 2]
        }

        public override void MakeSound()
        {
            Console.WriteLine(Name + " barks loudly.");[cite: 2]
        }

        public void Tricks()
        {
            Console.Write("A " + Breed + " that trained by " + Trainor + ", can do high-five ");[cite: 1]
        }
    }
}
