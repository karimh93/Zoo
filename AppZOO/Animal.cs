using System;
using System.Collections.Generic;
using System.Text;

namespace AppZOO
{
    public enum Food { Carrot, Apple, Milk, Bread, Chocolate, Grass };
    public enum AnimalType { Horse, Elephant, Cow, Cat, Dog, Giraffe };
    class Animal : IAnimalActions
    {
        private AnimalType animalType;
        private string animalName;
        private DateTime birthDate;
        private Food favouriteFood;

        /// <summary>
        /// get or set the favourite food of an animal. In time, the favourite food could change.
        /// </summary>
        public Food FavouriteFood
        {
            get { return favouriteFood; }
            set { favouriteFood = value; }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            private set { birthDate = value; }
        }

        public string AnimalName
        {
            get { return animalName; }
            set { animalName = value; }
        }

        public AnimalType AnimalType
        {
            get { return animalType; }
            private set { animalType = value; }
        }

        public Animal(string pName, AnimalType pAnimalType, DateTime pBirthDate, Food pFavouriteFood)
        {
            this.AnimalName = pName;
            this.AnimalType = pAnimalType;
            this.BirthDate = pBirthDate;
            this.FavouriteFood = pFavouriteFood;
        }

        public void Eat()
        {
            Console.WriteLine($"{AnimalName} has just eaten {FavouriteFood}.");
        }

        /// <summary>
        /// returns all the information about the current animal
        /// </summary>
        /// <returns></returns>
        public string AnimalInfo()
        {
            return $"Name: {AnimalName}, birth date: {BirthDate.Date.ToString("dd/MM/yyyy")}, favourite food: {FavouriteFood}";
        }

    }
}
