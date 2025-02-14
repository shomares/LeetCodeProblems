/*import {
  MinPriorityQueue,
} from '@datastructures-js/priority-queue';
 */



const {
  MinPriorityQueue,
} = require('@datastructures-js/priority-queue');


function minOperations(nums: number[], k: number): number {
  let result = 0
  const queue = new MinPriorityQueue()

  for (let item of nums) {
    queue.enqueue(item)
  }

  let front = queue.front().element

  if (front >= k) {
    return 0
  }

  do {
    const minor = queue.dequeue().element
    const major = queue.dequeue().element
    const calc = (minor * 2) + major
    queue.enqueue(calc)
    front = queue.front().element
    result++
  } while (front < k && queue.size() >= 2)

  return result
};

console.log(minOperations([1, 1, 2, 4, 9], 20))