function maxLengthBetweenEqualCharacters(s: string = "abbaba"): number {
    const dictionary = new Map<string, number>();
    let index = 0;
    let max = -1;

    while (index < s.length) {
        const c = s[index];

        if (dictionary.has(c)) {
            const difference = (index - 1) - dictionary.get(c);
            max = Math.max(difference, max);
        } else {
            dictionary.set(c, index);
        }

        index++;
    }


    return max;
};
