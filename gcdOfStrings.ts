function gcd(a: number, b: number): number {
    while (b !== 0) {
        const temp = b;
        b = a % b;
        a = temp;
    }
    return a;
}

function compareGcd(gcd:string, str: string): boolean {
    let index = 0
    let compare = ""
    let indexj = 0
    while (index < str.length) {
        if (index > 0 && index % gcd.length === 0) {
            if (compare !== gcd) {
                return false;
            }
            compare = str[index];
            index++
            continue
        }
        compare += str[index];
        index++;
        indexj++
    }

    if(compare!== "" && compare !== gcd){
        return false
    }

    return true
}

function gcdOfStrings(str1: string, str2: string): string {
    const gcdOfLenghts = gcd(str1.length, str2.length)

    let lowestStr = ""

    if (str1.length >= str2.length) {
        lowestStr = str2
    }
    else {
        lowestStr = str1
    }

    let gcdStr = ""
    let index = 0

    while (index < gcdOfLenghts) {
        gcdStr += lowestStr[index]
        index++
    }

    if(compareGcd(gcdStr, str1) && compareGcd(gcdStr, str2)){
        return gcdStr
    }

    return ""
};

//TAUXX
console.log(gcdOfStrings("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"))