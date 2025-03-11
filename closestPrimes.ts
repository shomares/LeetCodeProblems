function closestPrimes(left: number, right: number): number[] {
    if (right <= 2) {
        return [-1, -1]
    }

    const sieve = new Array<number>(right + 1).fill(1)
    sieve[0] = 0;
    sieve[1] = 0;
    let number = 2;
    while ((number * number) <= right) {
        if (sieve[number] === 0) {
            number++;
            continue;
        }

        let multiple = number * number
        while (multiple <= right) {
            sieve[multiple] = 0;
            multiple += number
        }


        number++;
    }

    const primes = []

    let index = 0

    while (index < sieve.length) {
        if (sieve[index] === 1) {
            primes.push(index)
        }

        index++
    }

    index = primes.length - 2

    let minDiff: number = null
    let valX = -1
    let valY = -1

    while (index >= 0) {

        let x = primes[index]
        let y = primes[index + 1]

        if (x < left) {
            break
        }

        const calc = x - y

        if (minDiff === null || minDiff < calc || (minDiff === calc && x < valX)) {
            minDiff = calc
            valX = x
            valY = y
        }

        index--
    }

    return [valX, valY]
};

console.log(closestPrimes(21, 25))