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
            if (list.Count == 0)
            {
                throw new ArgumentException("Invalid input.");
            }

            var wordDict = new Dictionary<string, WordOccurence>();

            foreach (var wordToCheck in list)
            {
                if (wordDict.ContainsKey(wordToCheck))
                {
                    wordDict[wordToCheck].Count += 1;
                }
                else
                {
                    wordDict.Add(wordToCheck, new WordOccurence() { Word = wordToCheck , Count = 1 });
                }

            }

            String retList = string.Join(Environment.NewLine, wordDict);

            return retList;

        }
    }
}
