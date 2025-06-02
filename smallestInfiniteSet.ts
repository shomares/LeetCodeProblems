import {
    MinPriorityQueue,
} from '@datastructures-js/priority-queue';


class SmallestInfiniteSet {

    private seen: Set<number>;
    private minPQ = new MinPriorityQueue<number>();

    constructor() {
        this.seen = new Set();
        this.minPQ = new MinPriorityQueue();
        for (let i = 1; i <= 1000; i++) {
            this.minPQ.enqueue(i);
        }
    }

    popSmallest(): number {
        const last = this.minPQ.dequeue()?.element ?? 1;
        this.seen.add(last);
        return last;
    }

    addBack(num: number): void {
        if (this.seen.has(num)) {
            this.minPQ.enqueue(num);
            this.seen.delete(num);
        }
    }
}

const smallestInfiniteSet = new SmallestInfiniteSet();
smallestInfiniteSet.addBack(2); // 2 is already in the set, so no change is made.
console.log(smallestInfiniteSet.popSmallest()); // return 1, since 1 is the smallest number, and remove it from the set.
console.log(smallestInfiniteSet.popSmallest()); // return 2, and remove it from the set.
console.log(smallestInfiniteSet.popSmallest()); // return 3, and remove it from the set.
smallestInfiniteSet.addBack(1); // 1 is added back to the set.
console.log(smallestInfiniteSet.popSmallest()); // return 1, since 1 was added back to the set and
// is the smallest number, and remove it from the set.
console.log(smallestInfiniteSet.popSmallest()); // return 4, and remove it from the set.
console.log(smallestInfiniteSet.popSmallest()); // return 5, and remove it from the set.
