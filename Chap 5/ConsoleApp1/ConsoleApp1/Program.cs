using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
	class Program
	{
		public static void Main()
		{

			//Dictionary's are collections of a key/value pairs - just strongly typed. They can be of any type(int, string, bool, custom, etc).

			//////////////////////////////////////
			////How to make a dictionary in C#///
			////////////////////////////////////
			//makes a dictionary named 'toysSold' and adds key value pairs at the sane time, you can also make an empty dictionary and use nameOfDictionary.Add(Key, Value)
			Dictionary<string, int> toysSold = new Dictionary<string, int>() {
					{"Hot Wheels", 344},
					{"Legos", 763},
					{"Gaming Consoles", 551},
					{"Board Games", 298}
				};
			//////////////////////////////////////////////////////////////////////////////////////////
			////how to use .Add(Key, Value) to add KeyValuePairs to the dictionary named "toysSold"///
			//////////////////////////////////////////////////////////////////////////////////////////
			//  "GI Joe" = Key   and   430 = Value || together they make a KeyValuePair
			toysSold.Add("GI Joe", 430);
			//access and print this newly added Value(430) to the console by using the key of "GI Joe"
			Console.WriteLine(toysSold["GI Joe"]);


			////////////////////////////////////////////////////////////////////////
			////How to loop over the dictionary and print each toy & its price/////
			///////////////////////////////////////////////////////////////////////
			Console.WriteLine("****toysSold Dictionary****");//title of list you are about to print
			foreach (KeyValuePair<string, int> word in toysSold)
			{
				Console.WriteLine($"{word.Key} price ${word.Value}");
			}



			//now lets make anither Dictionary that contains your top 5 video games, rank 1-5 would be of type 'int', and the name of the game would be type 'string'		
			////////////////////////////////////////////
			////How to make an empty dictionary in C#///
			////////////////////////////////////////////
			Dictionary<int, string> topTrucks = new Dictionary<int, string>();

			//now we have an empty dictionary called 'top5VideoGames, lets add some games with .Add() instead of using {key, value} after creating te Dictionary like the first dictionary we created      
			topTrucks.Add(1, "Monster Truck");
			topTrucks.Add(2, "Fire Truck");
			topTrucks.Add(3, "Monster Truck1");
			topTrucks.Add(4, "Fire Truck1");
			topTrucks.Add(5, "Monster Truck2");

			//Now lets loop over the dictionary and print each key value pair to the Console
			//First lets print a title to the console
			Console.WriteLine("****Top 5 Trucks of all time!!****");
			//loop over Dictionary and print each one
			foreach (KeyValuePair<int, string> game in topTrucks)
			{
				Console.WriteLine(game.Key + " " + game.Value);
			}


			//how to check if an int(key) is in the dictionary -- here we check if the Dictionary has a key of 3
			Console.WriteLine("***How to check if a certain key exists in a dictionary with an if-else statement***");
			//create an empty variable
			string value;
			if (topTrucks.ContainsKey(3))
			{
				value = topTrucks[3];
				Console.WriteLine($"{value} exists in the dictionary");
			}
			else
			{
				Console.WriteLine("Key Not Present");
				return;
			}

			/*
				   Create a dictionary with key value pairs to
				   represent words (key) and its definition (value)
		   */
			Dictionary<string, int> wordsAndDefinitions = new Dictionary<string, int>(){
				{"bitcoin", 1},
				{"shitcoins", 3},
				{"satoshi", 4 }
			};

			// Add several more words and their definitions
			wordsAndDefinitions.Add("Awesome", 5);
			wordsAndDefinitions.Add("C#", 6);
			wordsAndDefinitions.Add("4 Pillars of OOP", 7);

			/*
		   Use square bracket lookup to get the definition two
		   words and output them to the console
	   */

			// you can use nameOfDictionary[key] to search your dictionary and grab the value of the key, here 'bitcoin' is the key and 'magic internet money is the value'
			//first make a title so you can easily keep track of values you are printing to the console.
			Console.WriteLine("Returns the value(defintion) of the key specified, ex: nameOfDictionary[key]");
			Console.WriteLine(wordsAndDefinitions["bitcoin"]);
			Console.WriteLine(wordsAndDefinitions["satoshi"]);

			/*
                Loop over dictionary to get the following output:
                    The definition of [WORD] is [DEFINITION]
                    The definition of [WORD] is [DEFINITION]
                    The definition of [WORD] is [DEFINITION]
            */
			foreach (KeyValuePair<string, int> word in wordsAndDefinitions)

			{
				Console.WriteLine($" -{word.Key}- Definition: {word.Value}");
			}

			{

				// Make a new empty List, we will be creating a List of Dictionary's
				List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();



				//create an empty Dictionary named 'excited' then use .Add to insert some key/value pairs, we will add this to the empty list called 'dictionaryOfWords'
				Dictionary<string, string> excited = new Dictionary<string, string>();

				excited.Add("word", "excited");
				excited.Add("definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
				excited.Add("part of speech", "adjective");
				excited.Add("example sentence", "I am excited to learn C#!");

				dictionaryOfWords.Add(excited);



				Dictionary<string, string> bitcoin = new Dictionary<string, string>();

				bitcoin.Add("word", "bitcoin");
				bitcoin.Add("definition", "majik internet monies");
				bitcoin.Add("part of speech", "noun");
				bitcoin.Add("example sentence", "I am excited to stack bitcoin sats");



				dictionaryOfWords.Add(bitcoin);

				Dictionary<string, string> computers = new Dictionary<string, string>();

				computers.Add("word", "computers");
				computers.Add("definition", "boxes for data");
				computers.Add("part of speech", "noun");
				computers.Add("example sentence", "I am excited to computer");



				dictionaryOfWords.Add(computers);

				/*
					You want to track the following about each word:
						word, definition, part of speech, example sentence

					Example of one dictionary in the list:
				   {
						"word": "excited",
						"definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
						"part of speech": "adjective",
						"example sentence": "I am excited to learn C#!"
					}
				*/

				// Create dictionary to represent a few word
				// Dictionary<string, string> excitedWord = new Dictionary<string, string>();

				// Add each of the 4 bits of data about the word to the Dictionary
				// excitedWord.Add();

				// Add Dictionary to your `dictionaryOfWords` list


				// create another Dictionary and add that to the list


				/*
					Iterate your list of dictionaries and output the data

					Example output for one word in the list of dictionaries:
						word: excited
						definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
						part of speech: adjective
						example sentence: I am excited to learn C#!
				*/

				// Iterate the List of Dictionaries with a foreach loop inside another foreach loop
				//a foreach loop inside another foreach loop
				foreach (Dictionary<string, string> list in dictionaryOfWords)
				{

					Console.WriteLine("------");
					foreach (KeyValuePair<string, string> word in list)
					{

						Console.WriteLine($"{word.Key}: {word.Value} ");
					}


				}
				{
					//List in C# is similar to an array, 
					//This is a dictionary that is of type 'string' and type 'List', the key is the 'string' and the value is a 'List" of type 'strings'
					//ex: "Penny" = idioms[0].key
					Dictionary<string, List<string>> idioms = new Dictionary<string, List<string>>();
					idioms.Add("Penny", new List<string> { "A", "penny", "for", "your", "thoughts" });
					idioms.Add("Injury", new List<string> { "Add", "insult", "to", "injury" });
					idioms.Add("Moon", new List<string> { "Once", "in", "a", "blue", "moon" });
					idioms.Add("Grape", new List<string> { "I", "heard", "it", "through", "the", "grapevine" });
					idioms.Add("Murder", new List<string> { "Kill", "two", "birds", "with", "one", "stone" });
					idioms.Add("Limbs", new List<string> { "It", "costs", "an", "arm", "and", "a", "leg" });
					idioms.Add("Grain", new List<string> { "Take", "what", "someone", "says", "with", "a", "grain", "of", "salt" });
					idioms.Add("Fences", new List<string> { "I'm", "on", "the", "fence", "about", "it" });
					idioms.Add("Sheep", new List<string> { "Pulled", "the", "wool", "over", "his", "eyes" });
					idioms.Add("Lucifer", new List<string> { "Speak", "of", "the", "devil" });


					


					//this is to put a space between the words so the sentence is readable
					string emptySpace = " ";

					//Loop through the Dictionary with foreach and use .Join() to combine all the words in the 
					foreach (string key in idioms.Keys)

					{
						string results = String.Join(emptySpace, idioms[key]);
						Console.WriteLine($"{key}: {results} ");
					}
				}
			}
		}
		}
	}

