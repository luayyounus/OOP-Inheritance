﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Classes
{
    class Zoo
    {
        public string Name { get; set; }
        public int NumberOfAnimals { get; set; }
        public bool SouvenirShop { get; set; }

        public void Explore()
        {
            Console.WriteLine("Let's explore the remaining earthquake shacks and learn about the history of the zoo!");
        }
        public void Observe()
        {
            Console.WriteLine("Starring at the animals is so much fun! Look at that monkey monkeying! :)");
        }

        public void Pet()
        {
            Console.WriteLine("Every one likes to pet a cute animal.");
        }

        public void TakeARide()
        {
            Console.WriteLine("Take a ride on this little puffer train and get an up-close look at the grizzly bears foraging for food!");
        }
    }
}