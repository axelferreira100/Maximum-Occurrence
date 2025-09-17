using System.Collections.Generic;
using System.Linq;

namespace Library
{
    public class Program
    {
        public static string MaxOccur(string text)
        {
            Dictionary<char, int> charactersCounter = new Dictionary<char, int>();
            string lettersWithBiggestFrequency = "";

            foreach (char character in text)
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

            int maxValue = charactersCounter.Values.Max();

            if (maxValue == 1)
            {
                return "No Repetition";
            }

            foreach (KeyValuePair<char, int> kvp in charactersCounter)
            {
                if (kvp.Value == maxValue)
                {
                    if (lettersWithBiggestFrequency == "")
                    {
                        lettersWithBiggestFrequency += kvp.Key;
                    }
                    else
                    {
                        lettersWithBiggestFrequency += "," + kvp.Key;
                    }
                }
            }

            return lettersWithBiggestFrequency;
        }
    }
}