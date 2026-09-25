using System;

namespace LabActivity5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dog Instance
            Dog myDog = new Dog();
            myDog.Breed = "Golden Retriever";
            myDog.Trainor = "Mr. Cruz";

            myDog.Tricks();
            myDog.Run();

            Console.WriteLine(); // Blank line separator
            Console.WriteLine();

            // Cat Instance
            Cat myCat = new Cat();
            myCat.Breed = "Burmese";

            myCat.MakeSound();
            myCat.Walk();
        }
    }
}
