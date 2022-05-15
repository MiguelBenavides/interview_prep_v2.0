import { DialPadWordSuggestor } from "../src/dialPadSuggestions";

describe('Testing index file', () => {
    test("EmptyInputTest", () => {
        var input = "";
        var expectedOutput = [];

        var result = DialPadWordSuggestor.predict(input);

        expect(result).toStrictEqual(expectedOutput);
    });

    test("NoMatchTest", () => {
        var input = "1111";
        var expectedOutput = []

        var result = DialPadWordSuggestor.predict(input);

        expect(result).toStrictEqual(expectedOutput);
    });

    test("Example1Test", () => {
        var input = "117";
        var expectedOutput = [ "bat", "cat" ]

        var result = DialPadWordSuggestor.predict(input);

        expect(result).toStrictEqual(expectedOutput);
    });

    test("Example2Test", () => {
        var input = "119";
        var expectedOutput = [ "bay" ]

        var result = DialPadWordSuggestor.predict(input);

        expect(result).toStrictEqual(expectedOutput);
    });

    test("Example3Test", () => {
        var input = "252639";
        var expectedOutput = [ "energy" ]

        var result = DialPadWordSuggestor.predict(input);

        expect(result).toStrictEqual(expectedOutput);
    });
})