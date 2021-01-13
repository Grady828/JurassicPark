# JurassicPark

# Pedac

// Problem

- Create a console application that manages a dino zoo livestock inventory.

//Examples

- We have a Pterodactyl that is a omnivore that is 300lbs, named Sue, in enclosure number 17. We got Sue on Jan 8th of 2017.
- Jon is a Crocodile that weighs 300lbs, is a carnivore, that we received on June 20th of 2020, he is in enclosure 14.

//Data Structure

- name - string
- dietType - string
- WhenAquired - int
- weight - int
- EnclosureNumber - int

These attributes belong to a "Dinosaur" which I will represent as a class.

These "Dinosaurs" will be placed in a "list" to keep track of more than one

//Algorithm
-When the app runs it should let the user choose one of the following options.

Welcome User, please choose from the following
View
This command will show the all the dinosaurs in the list, ordered by WhenAcquired. If there aren't any dinosaurs in the park then print out a message that there aren't any.
Add
This command will let the user type in the information for a dinosaur and add it to the list. Prompt for the Name, Diet Type, Weight and Enclosure Number, but the WhenAcquired must be supplied by the code.
Remove
This command will prompt the user for a dinosaur name then find and delete the dinosaur with that name.
Transfer
This command will prompt the user for a dinosaur name and a new EnclosureNumber and update that dino's information.
Summary
This command will display the number of carnivores and the number of herbivores.
Quit
This will stop the program
