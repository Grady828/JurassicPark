using System;
using JurassicPark.Models;
using System.Linq;
using System.Collections.Generic;

namespace JurassicPark

{
    class Dino
    {
        public string Name { get; set; }
        public string DietType { get; set; }
        public int Weight { get; set; }
        public int EnclosureNumber { get; set; }
        public DateTime WhenAcquired;
    }
    class Program
    {

        static void Greeting(string message)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(message);
            Console.WriteLine();
            Console.WriteLine();
        }
        static void Main(string[] args)
        {


            var dinos = new List<Dino>() {
                new Dino()
            {
                Name = "Jim",
                DietType = "Carnivore",
                WhenAcquired = DateTime.Now,
                Weight = 8900,
                EnclosureNumber = 11,
            },
                new Dino()
            {
                Name = "Pam",
                DietType = "Carnivore",
                WhenAcquired = DateTime.Now,
                Weight = 9900,
                EnclosureNumber = 04,
            }, new Dino()
            {
                Name = "Pim",
                DietType = "Herbivore",
                WhenAcquired = DateTime.Now,
                Weight = 1700,
                EnclosureNumber = 10,
            }, new Dino()
            {
                Name = "Jam",
                DietType = "Herbivore",
                WhenAcquired = DateTime.Now,
                Weight = 234,
                EnclosureNumber = 13,
            }
            };
            var userHasChosenToQuit = false;
            while (userHasChosenToQuit == false)
            {

                Greeting("Hello, please choose from the following:");

                Console.WriteLine();
                Console.WriteLine("VIEW - See a list of all the dinosaurs");
                Console.WriteLine("ADD - Add a new dinosaur");
                Console.WriteLine("REMOVE - Delete a dinosaur from the list");
                Console.WriteLine("TRANSFERr - Move a dino from one enclosure to another one");
                Console.WriteLine("SUMMARY - Display the number of Carnivores and the number of Herbivores");
                Console.WriteLine("QUIT - Stop the App");
                Console.WriteLine();
                Console.WriteLine("What is your choice?");
                var choice = Console.ReadLine();
                string v = choice.ToUpper().Trim();
                choice = v;

                if (choice == "VIEW")
                {
                    foreach (var dino in dinos)
                    {
                        Console.WriteLine($"{dino.Name} is a {dino.DietType} that weighs {dino.Weight}lbs, we got them {dino.WhenAcquired} and they live in display # {dino.EnclosureNumber}");
                    }
                }
                if (choice == "ADD")
                {
                    //ask name,   
                    Console.WriteLine("What is the name? ");
                    var newDinoName = Console.ReadLine();
                    Console.WriteLine("What is it's diet? ");
                    var newDinoDiet = Console.ReadLine();
                    Console.WriteLine("What is its weight?");
                    var newDinoWeight = int.Parse(Console.ReadLine());

                    Console.WriteLine("What is it's enclosure Number");
                    var newDinoEnclosureNumber = int.Parse(Console.ReadLine());
                    var newDino = new Dino()
                    {
                        Name = newDinoName,
                        DietType = newDinoDiet,
                        WhenAcquired = DateTime.Now,
                        Weight = newDinoWeight,
                        EnclosureNumber = newDinoEnclosureNumber,
                    };

                    dinos.Add(newDino);
                }

                if (choice == "REMOVE")
                {
                    Console.WriteLine("What is the Dinos name");
                    var nameofDino = Console.ReadLine();
                    var foundDino = dinos.Find(dino => dino.Name == nameofDino);
                    dinos.Remove(foundDino);
                }
                if (choice == "SUMMARY")
                {
                    var totalCarnivores = dinos.Count(dino => dino.DietType == "Carnivore");
                    var totalHerbivores = dinos.Count(dino => dino.DietType == "Herbivore");

                    Console.WriteLine($"There are {totalHerbivores} Herbivores and {totalCarnivores} Carnivores");
                }
                if (choice == "TRANSFER")
                {
                    Console.WriteLine("What is the Dinos name");
                    var nameofDino = Console.ReadLine();
                    var foundDino = dinos.Find(dino => dino.Name == nameofDino);
                    Console.WriteLine("Which enclosure would you like to transfer the dino to?");
                    var newEnclosureNumber = int.Parse(Console.ReadLine());
                    foundDino.EnclosureNumber = newEnclosureNumber;


                }

                if (choice == "QUIT")
                {
                    userHasChosenToQuit = true;
                }
            }


        }
    }

}



