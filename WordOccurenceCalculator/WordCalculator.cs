using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordOccurenceCalculator
{
    internal class WordCalculator
    {
        public static String CalculateOccurrences(List<string> list)
        {
            // Check to see if the list was passed as empty and if so then throw an error 
            if (list.Count == 0)
            {
                throw new ArgumentException("Invalid input.");
            }

            // Create a new dictionary, {key = word, object = WordOccurence}
            var wordDict = new Dictionary<string, WordOccurence>();

            // For every word within the passed list, evaluate the word
            foreach (var wordToCheck in list)
            {
                // If it's already in the dictionary
                if (wordDict.ContainsKey(wordToCheck))
                {
                    // Then increment the counter for this word occurence object
                    wordDict[wordToCheck].Count += 1;
                }
                // If it's not already in the dictionary 
                else
                {
                    // Then add the word key and word occurence object to the dictionary 
                    wordDict.Add(wordToCheck, new WordOccurence() { Word = wordToCheck , Count = 1 });
                }

            }

            // Turn the dictionary into a giant list to send back to the client 
            var builder = new StringBuilder();
            foreach(var key in wordDict.Keys)
            {
                builder.Append(wordDict[key].Word);
                builder.Append(wordDict[key].Count);
                builder.Append("\n");

            }

            String alpha = builder.ToString();

            return alpha;

        }
    }
}
