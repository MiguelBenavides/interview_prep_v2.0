using System;
using System.Collections;
using System.Collections.Generic;

namespace WordGameSteps
{
    public class WordGameSteps
    {
        private class Node
        {
            public Node(string w)
            {
                Word = w;
                SimilarWords = new List<Node>();
            }

            public string Word;
            public List<Node> SimilarWords;
        }

        private static bool IsOneLetterDifferent(string word1, string word2)
        {
            if (word1.Length != word2.Length)
                return false;

            uint numOfDiff = 0;

            for(int i = 0; i < word1.Length; ++i)
                if (word1[i] != word2[i])
                    ++numOfDiff;

            return numOfDiff == 1;
        }

        private static Dictionary<string, Node> BuildGraph(string[] words)
        {
            var graph = new Dictionary<string, Node>();

            foreach(var word in words)
            {
                graph.Add(word, new Node(word));
            }

            foreach (var currentWordNode in graph)
            {
                var currentWord = currentWordNode.Key;
                var currentNode = currentWordNode.Value;

                foreach(var wordNode in graph)
                {
                    var word = wordNode.Key;
                    var node = wordNode.Value;

                    if (IsOneLetterDifferent(currentWord, word))
                        currentNode.SimilarWords.Add(node);
                }
            }

            return graph;
        }

        private static uint GetMaxSteps(string targetWord, Node currentNode, HashSet<Node> visited, uint currentSteps)
        {
            if (targetWord.Equals(currentNode.Word))
                return currentSteps;

            visited.Add(currentNode);

            uint maxSteps = 0;

            foreach (var similarWordNode in currentNode.SimilarWords)
            {
                if (!visited.Contains(similarWordNode))
                {
                    var steps = GetMaxSteps(targetWord, similarWordNode, visited, currentSteps + 1);

                    maxSteps = Math.Max(maxSteps, steps);
                }
            }

            visited.Remove(currentNode);

            return maxSteps;
        }

        private static uint GetMaxSteps(string targetWord, Node startingNode)
        {
            var visited = new HashSet<Node>();

            return GetMaxSteps(targetWord, startingNode, visited, 1);
        }

        public static uint FindMaxSteps(string startWord, string endWord, string[] words)
        {
            var graph = BuildGraph(words);

            uint maxSteps = 0;

            foreach(var wordNode in graph)
            {
                var word = wordNode.Key;
                var node = wordNode.Value;

                if(IsOneLetterDifferent(startWord, word))
                {
                    var steps = GetMaxSteps(endWord, node);

                    maxSteps = Math.Max(maxSteps, steps);
                }
            }

            return maxSteps;
        }
    }
}
