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

                    // Diet
                    Console.WriteLine("What is it's diet? ");
                    var newDinoDiet = Console.ReadLine();
                    //     weight
                    Console.WriteLine("What is its weight?");
                    var newDinoWeight = int.Parse(Console.ReadLine());

                    //     enclosure number
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

                if (choice == "QUIT")
                {
                    userHasChosenToQuit = true;
                }
                // This command will show the all the dinosaurs in the list, ordered by WhenAcquired. 
                // If there aren't any dinosaurs in the park then print out a message that there aren't any.
            }
            //If the user's choice is "quit", set boolean to true
            // (Back to loop) 



            // View


            // Add
            // This command will let the user type in the information for a dinosaur and add it to the list. Prompt for the Name, Diet Type, Weight and Enclosure Number, but the WhenAcquired must be supplied by the code.
            // Remove
            // This command will prompt the user for a dinosaur name then find and delete the dinosaur with that name.
            // Transfer
            // This command will prompt the user for a dinosaur name and a new EnclosureNumber and update that dino's information.
            // Summary
            // This command will display the number of carnivores and the number of herbivores.




        }
    }
}
