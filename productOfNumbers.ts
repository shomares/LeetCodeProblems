class ProductOfNumbers {
    constructor() {

    }

    cache: number[] = []

    add(num: number): void {
        if (num == 0) {
            this.cache.length = 0
            return
        }

        if (this.cache.length == 0) {
            this.cache.push(num)
            return
        }

        const lastItem = this.cache[this.cache.length - 1]
        this.cache.push(lastItem * num)
    }

    getProduct(k: number): number {
        const total = this.cache[this.cache.length - 1];
        if (k == this.cache.length) {
            return total;
        }
        const index = this.cache.length - k - 1;

        if (index < 0) {
            return 0
        }

        const divisor = this.cache[index];
        return total / divisor;
    }
}

let productOfNumbers = new ProductOfNumbers();
productOfNumbers.add(3);        // [3]
productOfNumbers.add(0);        // [3,0]
productOfNumbers.add(2);        // [3,0,2]
productOfNumbers.add(5);        // [3,0,2,5]
productOfNumbers.add(4);        // [3,0,2,5,4]
console.log(productOfNumbers.getProduct(2));

console.log(productOfNumbers.getProduct(3));
console.log(productOfNumbers.getProduct(4));
productOfNumbers.add(8);
console.log(productOfNumbers.getProduct(2));