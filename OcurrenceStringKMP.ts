//sadbutsad
//sad
function strStr(haystack: string, needle: string): number {
    let m = needle.length
    let lps = new Array<number>(needle.length).fill(0)

    let index = 1
    let indexj = 0

    while (index < m) {
        const a = needle[index]
        const b = needle[indexj]
        if (a == b) {
            indexj++
            lps[index] = indexj
            index++
        } else {
            if (indexj != 0) {
                indexj = lps[indexj - 1]
            }else{
                lps[index] = 0
                index++
            }
        }

    }

    index = 0
    indexj = 0

    while (index < haystack.length) {
        let a = haystack[index]
        let b = needle[indexj]

        if (a == b) {
            index++
            indexj++

            if (indexj == needle.length) {
                return index - needle.length
            }

            continue
        }

        if (indexj > 0)
            indexj = lps[indexj - 1]
        else
            index++
    }

    return -1
};

console.log(strStr("bababababcababcabab", "ababcabab"))
