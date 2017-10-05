using System;
using System.Collections.Generic;

namespace MontyHall
{
    internal class Program
    {
        private class Pill
        {
            public string Colour { get; set; }
            public Status isPoisonous { get; set; }
        }

        private enum Status
        {
            Poisonous,
            NotPoisonous
        }

        private static void Main()
        {
            int noOfDeaths = 0;
            int noOfDeaths2 = 0;
            
            Random randomGenerator = new Random();

            for (int i = 0; i < 100000; i++)
            {
                var jellies = new List<Pill>()
                {
                    new Pill {Colour = "Red", isPoisonous = Status.Poisonous},
                    new Pill {Colour = "Blue", isPoisonous = Status.Poisonous },
                    new Pill {Colour = "Green", isPoisonous = Status.Poisonous }
                };

                int randomPillIndex = randomGenerator.Next(0, 3);
                jellies[randomPillIndex].isPoisonous = Status.NotPoisonous;

                int index = randomGenerator.Next(0, 3);

                var userChoice = jellies[index];

                jellies.Remove(jellies[index]);

                var manChoice = jellies.Find(p => p.isPoisonous == Status.Poisonous);
                int indexTwo = jellies.IndexOf(manChoice);

                jellies.Remove(jellies[indexTwo]);
                
                if (userChoice.isPoisonous == Status.Poisonous)
                {
                    noOfDeaths += 1;
                }
                
            }

            for (int i = 0; i < 100000; i++)
            {
                var jellies = new List<Pill>()
                {
                    new Pill {Colour = "Red", isPoisonous = Status.Poisonous},
                    new Pill {Colour = "Blue", isPoisonous = Status.Poisonous },
                    new Pill {Colour = "Green", isPoisonous = Status.Poisonous }
                };

                int randomPillIndex = randomGenerator.Next(0, 3);
                jellies[randomPillIndex].isPoisonous = Status.NotPoisonous;

                int index = randomGenerator.Next(0, 3);

                var userChoice = jellies[index];

                jellies.Remove(jellies[index]);

                var manChoice = jellies.Find(p => p.isPoisonous == Status.Poisonous);
                int indexTwo = jellies.IndexOf(manChoice);

                jellies.Remove(jellies[indexTwo]);

                userChoice = jellies[0];

                if (userChoice.isPoisonous == Status.Poisonous)
                {
                    noOfDeaths2 += 1;
                }
            }

            Console.Write("Keep Pill Tests: 100000, Died: {0} times, ", noOfDeaths);
            Console.WriteLine("Die Persentage: {0:P2}", noOfDeaths / 100000.0);

            Console.Write("Change Pill Tests: 100000, Died: {0} times, ", noOfDeaths2);
            Console.WriteLine("Die Persentage: {0:P2}", noOfDeaths2 / 100000.0);

            Console.ReadLine();
        }
    }
}