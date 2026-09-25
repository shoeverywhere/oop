using System;

    namespace LabActivity5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Scenario 1: Golden Retriever
            Dog myDog = new Dog
            {
                Name = "Erick",
                Breed = "Golden Retriever",
                Trainor = "Mr. Cruz",
                Vaccine = "Rabies",
                DoB = "2022-05-10"
            };

            Console.WriteLine();
            myDog.Tricks();
            myDog.Run();

            Console.WriteLine();

            // Scenario 2: Burmese Cat
            Cat myCat = new Cat
            {
                Name = "Kitty",
                Breed = "Burmese",
                DoB = "2023-01-15"
            };

            myCat.MakeSound();
            myCat.Walk();
        }
    }
}
