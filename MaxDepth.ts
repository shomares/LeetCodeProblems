function maxDepth(s: string): number {
    const stack: string[] = [];
    let maximun = Number.MIN_VALUE;
    let index = 0;

    while (index < s.length) {
        const c = s[index];
        if (c == '(') {
            maximun = Math.max(stack.length , maximun);
            stack.push('(');
        } else if (c == ')') {
            maximun = Math.max(stack.length , maximun);
            stack.pop();
        }

        index++;
    }

    return maximun;
};

const s = maxDepth("1");
console.log(s);