using System;

/*
 This program is a simple Mad Libs game.
 It prompts the user to input various types of words (such as names, adjectives, and verbs),
 and then creates a funny story by inserting those words into a pre-defined template.
 Finally, it displays the generated story based on the user's inputs.
*/

namespace MadLibs
{
    class Program
    {   
        static void Main(string[] args)
        {
            // Starting message for the Mad Libs game
            Console.WriteLine("Mad Libs is starting!");
            Console.WriteLine();
            Console.WriteLine("Till the end...");
            Console.WriteLine();

            // Prompting user for various inputs
            string name = Prompt("Enter a name");
            string adj1 = Prompt("Enter a first adjective");
            string adj2 = Prompt("Enter a second adjective");
            string adj3 = Prompt("Enter a third adjective");
            string verb = Prompt("Enter a verb");
            string noun1 = Prompt("Enter a first noun");
            string noun2 = Prompt("Enter a second noun");
            string animal = Prompt("Enter an animal");
            string food = Prompt("Enter a food");
            string fruit = Prompt("Enter a fruit");
            string superhero = Prompt("Enter a superhero");
            string country = Prompt("Enter a country");
            string dessert = Prompt("Enter a dessert");
            string year = Prompt("Enter a year");

            // Construct the Mad Libs story by inserting user inputs into a pre-defined template
            string story =
                $"This morning {name} woke up feeling {adj1}. " +
                $"It is going to be a {adj2} day! Outside, a bunch of {animal}s were protesting to keep {food} in stores. " +
                $"They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adj3}. " +
                $"Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} " +
                $"in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";

            // Output the final story to the console
            Console.WriteLine();
            Console.WriteLine(story);
        }

        // This method asks the user for input and returns it as a string
        static string Prompt(string message)
        {
            // Display the prompt message and get user input
            Console.Write($"{message}: ");
            return Console.ReadLine();  // Return the user input
        }
    }
}