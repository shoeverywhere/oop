using System;

namespace LabActivity5
{
    class Animal
    {
        public string Name { get; set; }
        public string DoB { get; set; }

        public virtual void Walk()
        {
            Console.WriteLine("Animal is walking.");
        }

        public virtual void Run()
        {
            Console.WriteLine("Animal is running.");
        }

        public virtual void Play()
        {
            Console.WriteLine("Animal is playing.");
        }

        public virtual void Sleep()
        {
            Console.WriteLine("Animal is sleeping.");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound.");
        }
    }
}
