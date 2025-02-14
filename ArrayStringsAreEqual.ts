function arrayStringsAreEqual(word1: string[], word2: string[]): boolean {
    let indexw1 = 0
    let indexw2 = 0
    let indexk1 = 0
    let indexk2 = 0

    while (indexw1 < word1.length && indexw2 < word2.length) {
        const c1 = word1[indexw1][indexk1]
        const c2 = word2[indexw2][indexk2]

        if (c1 != c2) {
            return false
        }

        indexk1++
        indexk2++


        if (indexk1 == word1[indexw1].length) {
            indexw1++
            indexk1 = 0
        }

        if (indexk2 == word2[indexw2].length) {
            indexw2++
            indexk2 = 0
        }


        if (indexw1 == word1.length || indexw2 == word2.length) {
            break
        }
    }

    return indexw1 == word1.length &&
        indexw2 == word2.length &&
        indexk1 == 0 &&
        indexk2 == 0
};

console.log(arrayStringsAreEqual(["abc", "d", "defg"], ["abcddefg"]));
