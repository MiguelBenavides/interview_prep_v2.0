using System;
using System.Collections;
using System.Collections.Generic;


namespace DialPadWordSuggestion
{
    public class DialPadWordSuggestor
    {

        // Time complexity: O(n*l) where n -> input's lenth, l -> number of existing words.
        //
        // Space complexity: O(l) where l -> number of existing words.
        //
        public static List<String> SuggestDialPadWord(String input)
        {
            var newDict = new List<String>();

            // Filter by length.
            foreach(var word in WordDictionary)
                if (word.Length == input.Length)
                    newDict.Add(word);

            for(int charIndex = 0; charIndex < input.Length; charIndex++)
            {
                var inputNumber = input[charIndex];

                int wordIndex = 0;

                while (wordIndex < newDict.Count)
                {
                    var word = newDict[wordIndex];
                    var wordChar = word[charIndex];

                    var wordCharNumber = GetNumberFromLetter(wordChar);

                    if (wordCharNumber != inputNumber)
                    {
                        newDict.RemoveAt(wordIndex);
                    }
                    else
                    {
                        // Only increment index when not removing words.
                        wordIndex++;
                    }
                }
            }

            return newDict;
        }

        public static char GetNumberFromLetter(char letter)
        {
            char number;

            LetterToNumberDict.TryGetValue(letter, out number);

            return number;
        }


        private static readonly String[] WordDictionary = new String[] { "bat", "cat", "catalog", "energy", "baceball", "bay" };

        private static readonly Dictionary<char, char> LetterToNumberDict = new Dictionary<char, char>
        {
            { 'a', '1' },
            { 'b', '1' },
            { 'c', '1' },

            { 'd', '2' },
            { 'e', '2' },
            { 'f', '2' },

            { 'g', '3' },
            { 'h', '3' },
            { 'i', '3' },

            { 'j', '4' },
            { 'k', '4' },
            { 'l', '4' },

            { 'm', '5' },
            { 'n', '5' },
            { 'o', '5' },

            { 'p', '6' },
            { 'q', '6' },
            { 'r', '6' },

            { 's', '7' },
            { 't', '7' },
            { 'u', '7' },

            { 'v', '8' },
            { 'w', '8' },
            { 'x', '8' },

            { 'y', '9' },
            { 'z', '9' },

            { ' ', '0' }
        };
    }
}
