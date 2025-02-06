function areAlmostEqual(s1: string, s2: string): boolean {
    let index = 0;
    let antVars1: string;
    let antVars2: string;
    let notEqual = 0;
    let equal = 0;
    while (index < s1.length) {
        const c1 = s1[index];
        const c2 = s2[index];
        if (c1 == c2) {
            index++;
            equal++;
            continue;
        }
        
        if (antVars1 != undefined && antVars2 != undefined &&
            c1 == antVars1 && c2 == antVars2) {
            notEqual++;
        }

        antVars1 = c2;
        antVars2 = c1;
        index++;
    }

    return equal == (s1.length - (notEqual * 2)) && notEqual < 2;
};


console.log(areAlmostEqual("ysmpagrkzsmmzmsssutzgpxrmoylkgemgfcperptsxjcsgojwourhxlhqkxumonfgrczmjvbhwvhpnocz", "ysmpagrqzsmmzmsssutzgpxrmoylkgemgfcperptsxjcsgojwourhxlhkkxumonfgrczmjvbhwvhpnocz"))