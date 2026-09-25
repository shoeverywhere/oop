using System;

    namespace LabActivity5
{
    class Program
    {
        static void Main(string[] args)
        {
            
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
