using Microsoft.VisualStudio.TestTools.UnitTesting;
using DialPadWordSuggestion;
using System;
using System.Collections;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        // For this UT's condider the following words: { "bat", "cat", "catalog", "energy", "baceball", "bay" }


        [TestMethod]
        public void EmptyInputTest()
        {
            var input = "";
            var expectedOutput = new List<String> { };

            var result = DialPadWordSuggestor.SuggestDialPadWord(input);

            CollectionAssert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void NoMatchTest()
        {
            var input = "1111";
            var expectedOutput = new List<String> { };

            var result = DialPadWordSuggestor.SuggestDialPadWord(input);

            CollectionAssert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void Example1Test()
        {
            var input = "117";
            var expectedOutput = new List<String> { "bat", "cat" };

            var result = DialPadWordSuggestor.SuggestDialPadWord(input);

            CollectionAssert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void Example2Test()
        {
            var input = "119";
            var expectedOutput = new List<String> { "bay" };

            var result = DialPadWordSuggestor.SuggestDialPadWord(input);

            CollectionAssert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void Example3Test()
        {
            var input = "252639";
            var expectedOutput = new List<String> { "energy" };

            var result = DialPadWordSuggestor.SuggestDialPadWord(input);

            CollectionAssert.AreEqual(expectedOutput, result);
        }
    }
}
