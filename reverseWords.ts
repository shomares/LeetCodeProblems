function reverseWords(s: string): string {
    const arrayS = [...s];
    let index = 0;
    let indexj = arrayS.length - 1;
    while (index < indexj) {
        const aux = arrayS[index];
        arrayS[index] = arrayS[indexj];
        arrayS[indexj] = aux;
        index++;
        indexj--;
    }
    index = 0;
    indexj = 1;
    while (index < arrayS.length) {
        let c = arrayS[indexj];

        while (c != ' ' && indexj < arrayS.length) {
            c = arrayS[++indexj]
        }

        let indexk = indexj - 1;
        while (index < indexk) {
            const aux = arrayS[index];
            arrayS[index] = arrayS[indexk];
            arrayS[indexk] = aux;
            indexk--;
            index++;
        }
        index = indexj;

        c = arrayS[index];

        while (c == ' ' && index < arrayS.length) {
            c = arrayS[++index]
        }

        if (index == indexj + 1) {
            indexj = index + 1
            continue
        }

        let indexSaved = indexj + 1
        indexj++
        c = arrayS[index]
        while (c != ' ' && index < arrayS.length && indexj < arrayS.length) {
            c = arrayS[index]
            const aux = arrayS[index];
            arrayS[index] = arrayS[indexj];
            arrayS[indexj] = aux;
            indexj++;
            index++;
        }

        index = indexSaved
        indexj = indexSaved + 1
    }

    return arrayS.join("").trim();

};

console.log(reverseWords("  hello world  "))