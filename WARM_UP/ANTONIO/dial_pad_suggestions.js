var keyMap = {
    '1': 'abc',
    '2': 'def',
    '3': 'ghi',
    '4': 'jkl',
    '5': 'mno',
    '6': 'pqr',
    '7': 'stu',
    '8': 'vwx',
    '9': 'yz',
    '0': ' '
}

var dictionary = ["bat", "cat", "catalog", "energy", "baceball"]

function predict(input) {

    let buckets = {
        's': [],
        '1': [],
        '2': [],
        '3': [],
        '4': [],
        '5': [],
        '6': [],
        '7': [],
        '8': [],
        '9': [],
        '0': []
    };

    input = input.toString()
    let length = input.length;
    let suggestions = dictionary

    for (let i = 0; i <= length; i++) {
        let digit = input[i]

        for (let j = 0; j < suggestions.length; j++) {
            let word = suggestions[j]
            let c = word.charAt(i);

            if (c === '') {
                buckets['s'].push(word);
                continue;
            }
            
            if (keyMap[digit] && keyMap[digit].includes(c)) {
                buckets[digit].push(word);
            }
        }

        if (i >= length) {
            suggestions = buckets['s'];
            break;
        }

        suggestions = [];
        Object.keys(buckets).forEach(key => {
            let bucket = buckets[key];
            while (bucket.length > 0) {
                suggestions.push(bucket.shift());
            }
        })
    }

    return suggestions.slice(0, 4);

}

console.log(predict(117));