namespace Petshop;

class Program
{

    public class Animal
    {
        public string? Name;
        public int Age;
        public string? Type;

    }
    static void Main(string[] args)
    {
        Animal[] Animal = new Animal[4];
        string? result;

        Initialize();
        AddData();

        void Initialize()
        {
            for (int j = 0; j < Animal.Length; j++)
            {
                Animal[j] = new Animal();
            }
        }

        void AddData()
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

        //list animals
        for (int i = 0; i < Animal.Length; i++)
        {
            if (Animal[i].Name != null)
                Console.WriteLine($"Type: {Animal[i].Type}\tName: {Animal[i].Name}\tAge: {Animal[i].Age}");

        }

        //add animal
        for (int i = 0; i < Animal.Length; i++)
        {
            if (Animal[i].Name == null)
            {

                Console.WriteLine($"Add animal type: ");
                result = Console.ReadLine();
                Animal[i].Type = result;
                Console.WriteLine($"Add animal name: ");
                result = Console.ReadLine();
                Animal[i].Name = result;
                // Console.WriteLine($"Add animal age: ");
                // result = Console.ReadLine();
                // Animal[i].Age = int.TryParse(result, out int number)
            }

            // else
            // {
            //     Console.WriteLine($"Sorry, we are unable to accomodate any more animals. The max number is {Animal.Length}");
            // }

        }
        for (int i = 0; i < Animal.Length; i++)
        {
            if (Animal[i].Name != null)
                Console.WriteLine($"Type: {Animal[i].Type}\tName: {Animal[i].Name}\tAge: {Animal[i].Age}");

        }
    }
}
