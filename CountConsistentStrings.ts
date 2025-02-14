function countConsistentStrings(allowed: string, words: string[]): number {
    const hashTable = new Set<string>(allowed)
    let result = 0
    let index = 0

    while (index < words.length) {
        const word = words[index]
        let indexj = 0

        while (indexj < word.length) {
            const c = word[indexj]

            if (!hashTable.has(c)) {
                break
            }

            indexj++
        }

        if (indexj == word.length) {
            result++
        }

        index++
    }

    return result
};

console.log(countConsistentStrings("ab", ["ad", "bd", "aaab", "baa", "badab"]))