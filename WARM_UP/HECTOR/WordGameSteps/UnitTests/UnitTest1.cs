using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordGameSteps;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var words = new string[]{ "you", "cog", "hot", "dog", "hog", "fog" };

            var startWord = "hit";
            var endWord = "cog";

            uint expectedMaxSteps = 5;
            uint maxSteps = WordGameSteps.WordGameSteps.FindMaxSteps(startWord, endWord, words);

            Assert.AreEqual(expectedMaxSteps, maxSteps);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var words = new string[]{ "you", "cog", "hot", "dog", "hog", "fog" };

            var startWord = "hit";
            var endWord = "hot";

            uint expectedMaxSteps = 1;
            uint maxSteps = WordGameSteps.WordGameSteps.FindMaxSteps(startWord, endWord, words);

            Assert.AreEqual(expectedMaxSteps, maxSteps);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var words = new string[]{ "you", "cog", "hot", "dog", "hog", "fog" };

            var startWord = "log";
            var endWord = "hog";

            uint expectedMaxSteps = 4;
            uint maxSteps = WordGameSteps.WordGameSteps.FindMaxSteps(startWord, endWord, words);

            Assert.AreEqual(expectedMaxSteps, maxSteps);
        }

        [TestMethod]
        public void EmptyDictionaryTest()
        {
            var words = new string[] { };

            var startWord = "hit";
            var endWord = "cog";

            uint expectedMaxSteps = 0;
            uint maxSteps = WordGameSteps.WordGameSteps.FindMaxSteps(startWord, endWord, words);

            Assert.AreEqual(expectedMaxSteps, maxSteps);
        }

        [TestMethod]
        public void NoEndWordInDictTest()
        {
            var words = new string[] { "you", "cog", "hot", "dog", "hog", "fog" };

            var startWord = "hit";
            var endWord = "bro";

            uint expectedMaxSteps = 0;
            uint maxSteps = WordGameSteps.WordGameSteps.FindMaxSteps(startWord, endWord, words);

            Assert.AreEqual(expectedMaxSteps, maxSteps);
        }

        [TestMethod]
        public void InvalidStartWordTest()
        {
            var words = new string[] { "you", "cog", "hot", "dog", "hog", "fog" };

            var startWord = "pay";
            var endWord = "hot";

            uint expectedMaxSteps = 0;
            uint maxSteps = WordGameSteps.WordGameSteps.FindMaxSteps(startWord, endWord, words);

            Assert.AreEqual(expectedMaxSteps, maxSteps);
        }

        [TestMethod]
        public void NoStartToEndPathTest()
        {
            var words = new string[] { "you", "cog", "hot", "dog", "hog", "fog" };

            var startWord = "pou";
            var endWord = "hot";

            uint expectedMaxSteps = 0;
            uint maxSteps = WordGameSteps.WordGameSteps.FindMaxSteps(startWord, endWord, words);

            Assert.AreEqual(expectedMaxSteps, maxSteps);
        }
    }
}
