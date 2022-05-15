#Use at cmd to test: python -m unittest test.py

import unittest
import WordGameSteps

class TestWordGame(unittest.TestCase):
    def test_1(self):
        result = WordGameSteps.WordGame.wordGameSteps(self ,"hit", "cog", ["hot","dot","dog","lot","log","cog"])
        self.assertEqual(result, 5)

    def test_2(self):
        result = WordGameSteps.WordGame.wordGameSteps(self ,"hit", "cog", ["hot","dot","dog","lot","log"])
        self.assertEqual(result, 0)