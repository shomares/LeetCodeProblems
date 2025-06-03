
import {
    MinPriorityQueue
} from '@datastructures-js/priority-queue';



function totalCost(costs: number[], k: number, candidates: number): number {
    let times = 0
    let result = 0

    let i = 0
    let r = costs.length - 1

    const leftItems = new MinPriorityQueue<number>()
    const rightItems = new MinPriorityQueue<number>()

    while (times < k) {

        while (i <= r && leftItems.size() < candidates) {
            leftItems.enqueue(costs[i])
            i++
        }

        while (r > i - 1 && rightItems.size() < candidates) {
            rightItems.enqueue(costs[r])
            r--
        }

        const leftMinus = leftItems.size() > 0 ? leftItems.front().element : Number.MAX_SAFE_INTEGER
        const rightMinus = rightItems.size() > 0 ? rightItems.front().element : Number.MAX_SAFE_INTEGER

        if (leftMinus === Number.MAX_SAFE_INTEGER && leftMinus === rightMinus) {
            return result
        }

        if (leftMinus <= rightMinus) {
            result += leftMinus
            leftItems.dequeue()
        } else {
            result += rightMinus
            rightItems.dequeue()
        }

        times++
    }

    return result
};


console.log(totalCost([17, 12, 10, 2, 7, 2, 11, 20, 8], 3, 4))
