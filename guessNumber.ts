/** 
 * Forward declaration of guess API.
 * @param {number} num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * var guess = function(num) {}
 */

let pick = 1

const guess = (num) => {
    if (num > pick) {
        return -1
    }

    if (num < pick) {
        return 1
    }

    return 0
};

function guessNumber(n: number): number {
    let left = 0
    let right = n
    let middle = 0

    while (left <= right) {

        middle = Math.floor(left + (right - left) / 2)
        const result = guess(middle)

        if (result === 0) {
            return middle
        }

        if (result === -1) {
            right = middle - 1
        } else {
            left = middle + 1
        }

    }

    return 1
};

console.log(guessNumber(1))