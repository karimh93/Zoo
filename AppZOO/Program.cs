using System;

namespace AppZOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from the ZOO!");
            Zoo zoo1 = new Zoo("Bucuresti ");
            Zoo zoo2 = new Zoo("Iasi");

            //let's born some animals at Iasi zoo  :))
            Animal animal1 = new Animal("Hippo", AnimalType.Elephant, DateTime.Now, Food.Milk);
            Animal animal2 = new Animal("Giffy", AnimalType.Giraffe, DateTime.Now, Food.Grass);

            zoo2.BornNewAnimal(animal1);
            zoo2.BornNewAnimal(animal2);

            //let's feed the animals
            animal1.Eat();
            animal2.Eat();

            //let's see the list of the animals from Iasi zoo
            zoo2.PrintAnimalList();

            //let's transfer some animal from Iasi to Bucuresti
            zoo2.TransferAnimal(zoo1, animal1);
            //let's see the list of the animals from Bucuresti zoo
            zoo2.PrintAnimalList();
            //and from Iasi zoo
            zoo1.PrintAnimalList();

            //let's bring an animal to Bucuresti from Iasi
            zoo2.TransferAnimal(zoo1, animal2);
            //let's see the final lists of the animals
            zoo2.PrintAnimalList();
            zoo1.PrintAnimalList();
            
        }
    }
}
