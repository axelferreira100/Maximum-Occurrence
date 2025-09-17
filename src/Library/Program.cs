using System.Collections.Generic;
using System.Linq;

namespace Library
{
    public class Program
    {
        public static string MaxOccur(string text)
        {
            Dictionary<char, int> charactersCounter = new Dictionary<char, int>();
            string[] listOfWordsInText = text.Split(" ");

            foreach (string word in listOfWordsInText)
            {
                foreach (char character in word)
                {
                    if (!charactersCounter.ContainsKey(character))
                    {
                        charactersCounter.Add(character, 1);
                    }
                    else
                    {
                        charactersCounter[character]++;
                    }
                }
            }
            
            
        }
    }
}