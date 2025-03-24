using System;

namespace Petshop
{
    public class Animal
    {
        public string? Name;
        public int Age;
        public string? Type;
    }

    class Program
    {
        static Animal[] Animal = new Animal[5];
        static string? result;

        static void Main(string[] args)
        {
            // Calling methods
            Initialize();
            AddData();

            while (true)
            {
                Console.WriteLine("Type 'list' to view current animals, 'add' to add an animal or 'exit' to quit");
                result = Console.ReadLine();

                if (result == "exit")
                    break;

                if (result == "list")
                    ListAnimals();

                if (result == "add")
                    AddAnimals();
            }
        }

        public static void Initialize()
        {
            for (int j = 0; j < Animal.Length; j++)
            {
                Animal[j] = new Animal();
            }
        }

        public static void AddData()
        {
            Animal[0].Name = "Bones";
            Animal[0].Age = 2;
            Animal[0].Type = "dog";

            Animal[1].Name = "Jonesy";
            Animal[1].Age = 4;
            Animal[1].Type = "cat";

            Animal[2].Name = "Pip";
            Animal[2].Age = 3;
            Animal[2].Type = "mouse";
        }

        public static void ListAnimals()
        {
            for (int i = 0; i < Animal.Length; i++)
            {
                if (Animal[i].Name != null)
                    Console.WriteLine($"Type: {Animal[i].Type}\tName: {Animal[i].Name}\tAge: {Animal[i].Age}");
            }
            Console.WriteLine();
        }

        public static void AddAnimals()
        {
            bool ageIsANumber = false;
            int counter = 0;
            bool breakLoop = false;

            for (int i = 0; i < Animal.Length; i++)
            {
                if (breakLoop)
                    break;

                if (Animal[i].Name == null)
                {
                    Console.WriteLine("Add animal type: ");
                    result = Console.ReadLine();
                    Animal[i].Type = result;

                    Console.WriteLine("Add animal name: ");
                    result = Console.ReadLine();
                    Animal[i].Name = result;

                    ageIsANumber = false;

                    while (!ageIsANumber)
                    {
                        Console.WriteLine("Add animal age: ");
                        result = Console.ReadLine();

                        if (int.TryParse(result, out int number))
                        {
                            Animal[i].Age = number;
                            ageIsANumber = true;
                        }
                        else
                        {
                            Console.WriteLine($"'{result}' is not a number.");
                        }
                    }

                    while (result != "yes" && result != "no")
                    {
                        Console.WriteLine("Do you wish to add another animal ('yes' or 'no')");
                        result = Console.ReadLine();
                        if (result == "no")
                        {
                            breakLoop = true;
                            break;
                        }
                        else if (result == "yes")
                        {
                            AddAnimals();
                            breakLoop = true;
                            break;
                        }
                    }
                }
                else
                {
                    counter += 1;
                    if (counter >= Animal.Length)
                    {
                        Console.WriteLine($"Sorry, we are unable to accommodate any more animals. The max number is {Animal.Length}");
                        break;
                    }
                }
            }
        }
    }
}
