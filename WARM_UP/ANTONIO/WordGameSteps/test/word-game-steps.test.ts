import { WordGameSteps } from "../src/word-game-steps";

function exampleTest() {
    var beginWord = 'hit', endWord = 'cog';
    var dictionary = ["hot", "hog", "dog", "fog", "cog", "you"];
    var expected = 5;

    var result = new WordGameSteps().play(beginWord, endWord, dictionary);

    expect(result).toBe(expected);
}

function emptyDictionary() {
    var beginWord = 'hit', endWord = 'cog';
    var dictionary = [];
    var expected = 0;

    var result = new WordGameSteps().play(beginWord, endWord, dictionary);

    expect(result).toBe(expected);
}

function multipleMaxPaths() {
    var beginWord = 'hit', endWord = 'cog';
    var dictionary = ["hot", "hig", "hug", "hut", "hog", "dog", "fog", "cog", "you"];
    var expected = 8;

    var result = new WordGameSteps().play(beginWord, endWord, dictionary);

    expect(result).toBe(expected);
}

function testMethod2() {
    var beginWord = "hit", endWord = "hot";
    var dictionary = ["you", "cog", "hot", "dog", "hog", "fog"];
    let expected = 1;

    let result = new WordGameSteps().play(beginWord, endWord, dictionary);

    expect(result).toBe(expected);
}

function testMethod3() {
    var beginWord = "log", endWord = "hog";
    var dictionary = ["you", "cog", "hot", "dog", "hog", "fog"];
    let expected = 4;

    let result = new WordGameSteps().play(beginWord, endWord, dictionary);

    expect(result).toBe(expected);
}

function noEndWordInDictTest() {
    var beginWord = "hit", endWord = "bro";
    var dictionary = ["you", "cog", "hot", "dog", "hog", "fog"];
    let expected = 0;

    let result = new WordGameSteps().play(beginWord, endWord, dictionary);

    expect(result).toBe(expected);
}

function invalidbeginWordTest() {
    var beginWord = "pay", endWord = "hot";
    var dictionary = ["you", "cog", "hot", "dog", "hog", "fog"];
    let expected = 0;

    let result = new WordGameSteps().play(beginWord, endWord, dictionary);

    expect(result).toBe(expected);
}

function noStartToEndPathTest() {
    var beginWord = "pou", endWord = "hot";
    var dictionary = ["you", "cog", "hot", "dog", "hog", "fog"];
    let expected = 0;

    let result = new WordGameSteps().play(beginWord, endWord, dictionary);

    expect(result).toBe(expected);
}

function tests() {
    test('Example input test', exampleTest);
    test('Empty dictionary', emptyDictionary);
    test('Multiple longer paths', multipleMaxPaths);
    test('Example input test 2', testMethod2);
    test('Example input test 3', testMethod3);
    test('No end word in dictionary test', noEndWordInDictTest);
    test('Invalid begin word', invalidbeginWordTest);
    test('No start to end path test', noStartToEndPathTest);
}

describe('Word Game Steps tests', tests)