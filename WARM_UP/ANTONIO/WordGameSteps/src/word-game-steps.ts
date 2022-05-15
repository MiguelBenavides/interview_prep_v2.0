export class WordGameSteps {

    private dictionary: string[];
    private wordMap: Map<string, Set<string>>;

    private maxPoints: number = 0;

    constructor() {
        this.maxPoints = 0;
    }

    public play(beginWord: string, endWord: string, dictionary: string[]): number {
        if (dictionary.length < 1 || !dictionary.includes(endWord)) {
            return 0;
        }

        this.dictionary = dictionary;

        this.buildDictionaryWordMap();
        this.addBeginWordEntrytToWordMap(beginWord);

        this.getLongestPathToEndWordWithinDictionary(beginWord, endWord);
        return this.maxPoints;
    }

    private getLongestPathToEndWordWithinDictionary(
        beginWord: string,
        endWord: string,
        points: number = 0,
        processedWords: Set<string> = new Set()): number {
        
        processedWords.add(beginWord);
        if (beginWord === endWord) {
            processedWords.delete(beginWord);
            if (this.maxPoints < points) {
                this.maxPoints = points;
            }
            return points
        }
        let nextWords = this.wordMap.get(beginWord);
        let iterator1 = nextWords.values();
        for (const word of iterator1) {
            if (processedWords.has(word)) { continue; }
            this.getLongestPathToEndWordWithinDictionary(word, endWord, points + 1, processedWords);
            
        }
        processedWords.delete(beginWord);
    }

    private addBeginWordEntrytToWordMap(beginWord: string): void {
        let dict = this.dictionary;
        
        let nextWords = new Set<string>();
        dict.forEach(w => {
            if (this.isWordOneLetterApart(beginWord, w)) {
                nextWords.add(w);
            }
        });
        this.wordMap.set(beginWord, nextWords)
    }

    private buildDictionaryWordMap(): void {
        var dict = this.dictionary;
        
        this.wordMap = new Map<string, Set<string>>(
            dict.map(x => [x, new Set<string>()])
        )
        dict.forEach((w, index) => {
            for (let i = index + 1; i < dict.length; i++) {
                let word = dict[i];
                if (this.isWordOneLetterApart(w, word)) {
                    this.wordMap.get(w).add(word);
                    this.wordMap.get(word).add(w);
                }
            }
        });
    }

    private isWordOneLetterApart(curr, next): boolean {
        let diffLetCount = 0;
        for (let i = 0; i < curr.length; i++) {
            if (curr[i] !== next[i]) {
                diffLetCount++;
            }
        }
        if (diffLetCount === 1) {
            return true
        }

        return false;
    }
}