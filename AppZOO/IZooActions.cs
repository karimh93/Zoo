using System;
using System.Collections.Generic;
using System.Text;

namespace AppZOO
{
    interface IZooActions
    {
        /// <summary>
        /// transfer an animal from the current zoo to a destination zoo
        /// </summary>
        /// <param name="pDestinationZoo"></param>
        /// <param name="pAnimal"></param>
        void TransferAnimal(Zoo pDestinationZoo, Animal pAnimal);

        /// <summary>
        /// a new animal is born in the current zoo
        /// </summary>
        /// <param name="pAnimal"></param>
        void BornNewAnimal(Animal pAnimal);
    }
}
