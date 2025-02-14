function maxProfit2(prices: number[]): number {

    let index = 1
    let sumProfit = 0

    while (index < prices.length) {
        const sum = prices[index] + prices[index - 1]
        if (sum > 0) {
            sumProfit += sum
        }
        index++
    }

    return 0
};

console.log(maxProfit2([7, 1, 5, 3, 6, 4]))