

class RecentCounter {

    private queque = new Array<number>()


    constructor() {

    }

    ping(t: number): number {

        const diff = t - 3000

        if (diff <= 0) {
            this.queque.push(t)
            return this.queque.length
        }

        while (this.queque[0] < diff) {
            this.queque.shift()
        }

        this.queque.push(t)
        return this.queque.length
    }
}

/**
 * Your RecentCounter object will be instantiated and called as such:
 * var obj = new RecentCounter()
 * var param_1 = obj.ping(t)
 */

const recentCounter = new RecentCounter();
console.log(recentCounter.ping(1));     // requests = [1], range is [-2999,1], return 1
console.log(recentCounter.ping(100));   // requests = [1, 100], range is [-2900,100], return 2
console.log(recentCounter.ping(3001));  // requests = [1, 100, 3001], range is [1,3001], return 3
console.log(recentCounter.ping(3002));  // requests = [1, 100, 3001, 3002], range is [2,3002], return 3
console.log(recentCounter.ping(3003));  // requests = [1, 100, 3001, 3002], range is [2,3002], return 3