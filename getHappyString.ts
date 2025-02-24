const result: string[] = []

function recursiveHappyString(prefix: string, n: number, pattern: string[], parent: number) {
    if (prefix.length == n) {
        result.push(prefix)
        return
    }

    let index = 0

    while (index < pattern.length) {
        const c = pattern[index]
        if (c == pattern[parent]) {
            index++
            continue
        }

        const newPrefix = prefix + c
        recursiveHappyString(newPrefix, n, pattern, index)
        index++
    }

}


function getHappyString(n: number, k: number): string {

    let index = 0

    result.length = 0
    const pattern = ['a', 'b', 'c']
    while (index < pattern.length) {
        const c = pattern[index]
        recursiveHappyString(c, n, pattern, index)
        index++
    }

    return result[k - 1]??''
};

console.log(getHappyString(3, 9))