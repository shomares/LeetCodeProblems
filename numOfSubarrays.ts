function numOfSubarrays(arr: number[]): number {
    let count = 0
    let index = 0
    const MOD = 1e9 + 7;

    let par = 1
    let impar = 0
    let prefixSum = 0
    while (index < arr.length) {
        prefixSum += arr[index]
        //Par
        if (prefixSum % 2 == 0) {
            count += impar
            par++
        } else {
            count += par
            impar++
        }

        count = count % MOD
        index++
    }


    return count
};

console.log(numOfSubarrays([1, 3, 5, 6]))