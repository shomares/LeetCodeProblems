function repeatedSubstringPattern(s: string): boolean {
    if (s.length == 1) {
        return false;
    }
    //KMP apply
    let lps = new Array(s.length).fill(0);
    let index = 1;
    let indexj = 0;
    let m = s.length;
    while (index < m) {
        const a = s[index];
        const b = s[indexj];
        if (a == b) {
            indexj++;
            lps[index] = indexj;
            index++;
        }
        else {
            if (indexj != 0) {
                indexj = lps[indexj - 1]
            }
            else {
                lps[index] = 0;
                index++;
            }
        }
    }

    if (indexj == 0) {
        return false
    }

    const lengthPattern = s.length - indexj;
    return s.length % lengthPattern == 0;
};

console.log(repeatedSubstringPattern("abaababaab"))