function maximumWealth(accounts: number[][]): number {
    let max = 0

    let index =0

    while(index< accounts.length){
        const array = accounts[index]
        let sum = array.reduce((a,b)=> a+ b, 0)
        max = Math.max(sum , max)
        index++
    }

    return max
};

console.log(maximumWealth([[1,2,3],[3,2,1]]))