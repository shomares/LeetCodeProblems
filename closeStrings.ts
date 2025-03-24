const convertToMapFrecuency = (word: string): { [key: string]: number } => {
    const s1: { [key: string]: number } = {}
    let index = 0

    while (index < word.length) {
        const c = word[index]
        s1[c] = s1[c] === undefined ? 1 : s1[c] + 1
        index++
    }

    return s1
}

const convertToArray = (map: { [key: string]: number }) => {
    const array: number[] = []

    for (let item in map) {
        array.push(map[item])
    }

    array.sort((a, b) => a - b)
    return array
}


function closeStrings(word1: string, word2: string): boolean {

    if (word1.length != word2.length) {
        return false
    }

    const s1 = convertToMapFrecuency(word1)
    const s2 = convertToMapFrecuency(word2)

    for (let property in s1) {
        if (s2[property] === undefined) {
            return false
        }
    }

    const s1Frequency = convertToArray(s1)
    const s2Frequency = convertToArray(s2)

    let index = 0

    while(index < s1Frequency.length){
        if(s1Frequency[index]!== s2Frequency[index]){
            return false
        }

        index++
    }

    return true

};

console.log(closeStrings("cabbba", "abbccc"))