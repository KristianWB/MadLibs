using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program is a story poem game, where the player inserts words into a pregiven text and the result are funny stories
      Author: Kristian Witt Bergqvist
      */


      // Let the user know that the program is starting:
      Console.WriteLine("Welcome to Mad Libs game.. May the words be with you :D");


      // Give the Mad Lib a title:
      string title = "In the words of madness";

      Console.WriteLine(title);
      // Define user input and variables:
      Console.WriteLine("Enter a name for the main character: ");
      string mainCharacter = Console.ReadLine();

      // Entering 3 adjectivces adjectivea
      Console.WriteLine("To generate the story, we need three adjectives...");
      Console.WriteLine("When prompted, you must type in theese adjectivces");
      Console.WriteLine("Enter the first adjective: ");
      string firstAdjective = Console.ReadLine();

      Console.WriteLine("Enter the second adjective: ");
      string secondAdjective = Console.ReadLine();

      Console.WriteLine("Enter the third adjectivce: ");
      string thirdAdjective = Console.ReadLine();

      // The user also needs to enter a verb
      Console.WriteLine("Now you must enter a verb: ");
      string verb = Console.ReadLine();

      // The story needs two nouns
      Console.WriteLine("We now need two nouns");

       //First noun
      Console.WriteLine("Pleace enter the first noun: ");
      string firstNoun = Console.ReadLine();

      // Second noun
      Console.WriteLine("Enter the second noun: ");
      string secondNoun = Console.ReadLine();

      Console.WriteLine("Enter each one of the following...\n - An Animal:\n - A food: \n - A fruit: \n - A Superhero: \n - A country: \n - A dessert: \n - A year: \n");

      // Animal
      Console.WriteLine("Enter an animal");
      string animal = Console.ReadLine();
      
      // Food
      Console.WriteLine("Enter a food");
      string food = Console.ReadLine();

      // Fruit
      Console.WriteLine("Enter a fruit");
      string fruit = Console.ReadLine();

      // Superhero
      Console.WriteLine("Enter a superhero");
      string superHero = Console.ReadLine();

      //Country
      Console.WriteLine("Enter a country");
      string country = Console.ReadLine();

      // Dessert
      Console.WriteLine("Enter a dessert");
      string dessert = Console.ReadLine();

      // Year
      Console.WriteLine("Enter a year");
      string year = Console.ReadLine();



      // The template for the story:

      string story = $"This morning {mainCharacter} woke up feeling {firstAdjective}. 'It is going to be a {secondAdjective} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {firstNoun}, which made all the {fruit}s very {thirdAdjective}. Concerned, {mainCharacter} texted {superHero}, who flew {mainCharacter} to {country} and dropped {mainCharacter} in a puddle of frozen {dessert}. {mainCharacter} woke up in the year {year}, in a world where {secondNoun}s ruled the world.";


      // Print the story:
      Console.WriteLine(story);

    }
  }
}
