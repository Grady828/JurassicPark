using System;
using JurassicPark.Models;
using System.Linq;

namespace JurassicPark
{
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
            //       -When the app runs it should let the user choose one of the following options.

            // Welcome User, please choose from the following
            Greeting("Hello, please choose from the following:");

            Console.WriteLine();
            Console.WriteLine("View - See a list of all the dinosaurs");
            Console.WriteLine("Add - Add a new dinosaur");
            Console.WriteLine("Remove - Delete a dinosaur from the list");
            Console.WriteLine("Transfer - Move a dino from one enclosure to another one");
            Console.WriteLine("Summary - Display the number of Carnivores and the number of Herbivores");
            Console.WriteLine("Quit - Stop the App");
            Console.WriteLine();
            Console.WriteLine("What is your choice?");
            var choice = Console.ReadLine();

            // View
            // This command will show the all the dinosaurs in the list, ordered by WhenAcquired. If there aren't any dinosaurs in the park then print out a message that there aren't any.

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
