function maxRepeating(sequence: string, word: string): number {
    let index = 0
    let result = 0

    while (index < sequence.length) {

        let times = Math.floor((sequence.length - index) / word.length)
        let indexj = 0
        let indexk = index
        let counter = 0
        let antStr: string

        while (indexj < times) {
            let str = ""

            const to = indexk + word.length

            while (indexk < sequence.length && indexk < to) {
                str += sequence[indexk]
                indexk++
            }

            if (str != word) {
                antStr = str
                indexj++
                result = Math.max(counter, result);
                continue
            }

            if (antStr == undefined || antStr == str) {
                counter++
            } else {
                counter = 1
            }

            antStr = str
            indexj++
        }

        result = Math.max(counter, result)
        index++
    }

    return result
};

function longestRepeatedWord(sequence, word) {
    let n = sequence.length;
    let m = word.length;

    // dp[i] será el máximo número de repeticiones consecutivas de 'word' hasta el índice i
    let dp = new Array(n).fill(0);
    let result = 0;

    for (let i = 0; i < n; i++) {
        // Si encontramos una coincidencia de la palabra en la secuencia
        if (i + 1 >= m && sequence.substring(i - m + 1, i + 1) === word) {
            // Si encontramos una repetición, sumamos a la cantidad previa de repeticiones
            dp[i] = (i - m >= 0 ? dp[i - m] : 0) + 1;
        }
        // Actualizamos el resultado máximo
        result = Math.max(result, dp[i]);
    }

    return result;
}


console.log(maxRepeating("ababc", "ab"))

//ababc ->ab
//aaaba aaaba aabaa aabaa aabaa aabaa aaba 2

//aaabaaaab( (aaaba) (aaaba) (aaaba) (aaaba) (aaaba))
//aaaba aaab aaaba aaaba aaaba aaaba aaaba