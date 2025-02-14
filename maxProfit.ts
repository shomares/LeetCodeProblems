function maxProfit(prices: number[]): number {
    let minimun = prices[0]
    let profit = 0
    let index = 1

    while (index < prices.length) {
        const price = prices[index]

        if (minimun > price) {
            minimun = price
        } else {
            const calc = price - minimun
            profit = Math.max(profit, calc)
        }

        index++
    }


    return profit

};

console.log(maxProfit([7, 1, 5, 3, 6, 4]))