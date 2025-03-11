function mergeAlternately(word1: string, word2: string): string {
    let result= new Array<string>(word1.length + word2.length)
    let index = 0
    let indexj = 0
    let indexk = 0

    while (index < result.length) {

        if(indexj < word1.length){
            const w1 = word1[indexj]
            result[index] = w1;
            indexj++
            index++
        }
       
        if(indexk< word2.length){
            const w1 = word2[indexk]
            result[index] = w1;
            indexk++
            index++
        }

    }

    return result.join('')
};

console.log(mergeAlternately("ab", "pqrs"))