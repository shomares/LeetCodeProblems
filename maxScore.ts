
import {
    MinPriorityQueue
} from '@datastructures-js/priority-queue';


function maxScore(nums1: number[], nums2: number[], k: number): number {

    const pq = new MinPriorityQueue<number>()

    const mapping = nums2.map((value, index) => ({
        x: value,
        index,
        y: nums1[index]
    })).sort((a, b) => a.x - b.x)

    let index = nums2.length - 1
    let result = 0
    let count = 0
    let sum = 0

    while (index >= 0) {

        const { x, y } = mapping[index]
        sum += y
        pq.enqueue(y)
        count++
        if (count >= k) {
            if (pq.size() > k) {
                const minusValue = pq.dequeue().element
                sum -= minusValue
            }

            result = Math.max(result, sum * x)
        }

        index--
    }

    return result
};

console.log(maxScore([2, 1, 14, 12], [11, 7, 13, 6], 3))
