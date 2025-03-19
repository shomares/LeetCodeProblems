function isVowel(c: string) {
    return c === 'a'
        || c === 'e'
        || c === 'i'
        || c === 'o'
        || c === 'u'

}


function maxVowels(s: string, k: number): number {
    let counter = 0
    let index = 0
    let result = 0

    while (index < k) {
        const c = s[index]
        if (isVowel(c)) {
            counter++
        }

        index++
    }

    index = k
    result = counter

    while (index < s.length) {
        const firstItem = s[index - k]
        const c = s[index]

        if(isVowel(firstItem)){
            counter--
        }
      
        if (isVowel(c)) {
            counter++
        }

        result = Math.max(result, counter)
        index++
    }

    return result
};


console.log(maxVowels("abciiidef", 3))
