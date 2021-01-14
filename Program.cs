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
            var Jim = new Dino()
            {
                Name = "Jim",
                DietType = "Carnivore",
                WhenAcquired = DateTime.Now,
                Weight = 8900,
                EnclosureNumber = 11,
            };
            var Jam = new Dino()
            {
                Name = "Jam",
                DietType = "Herbivore",
                WhenAcquired = DateTime.Now,
                Weight = 234,
                EnclosureNumber = 13,
            };
            var Pim = new Dino()
            {
                Name = "Pim",
                DietType = "Herbivore",
                WhenAcquired = DateTime.Now,
                Weight = 1700,
                EnclosureNumber = 10,
            };
            var Pam = new Dino()
            {
                Name = "Pam",
                DietType = "Carnivore",
                WhenAcquired = DateTime.Now,
                Weight = 9900,
                EnclosureNumber = 04,
            };
            var dinos = new List<Dino>() { Jim, Jam, Pim };

            //       -When the app runs it should let the user choose one of the following options.

            // Welcome User, please choose from the following

            //while the user hasn't chosen to quit, keep a loop going until user quits
            // Algorithm : Before the loop set our boolean to false : they havent quit
            var userHasChosenToQuit = false;
            // While our boolean is false: show the menu
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

                // This command will show the all the dinosaurs in the list, ordered by WhenAcquired. 
                // If there aren't any dinosaurs in the park then print out a message that there aren't any.
                // For every dino do the following: Print name, dietType, whenAquired, weight, enclosureNumber

                foreach (var dino in dinos)
                    Console.WriteLine($"{dino.Name} is a {dino.DietType} that weighs {dino.Weight}lbs, we got them {dino.WhenAcquired} and they live in display # {dino.EnclosureNumber}");


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
            // Quit
            // This will stop the program


        }
    }
}
