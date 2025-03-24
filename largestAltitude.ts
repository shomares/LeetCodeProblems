function largestAltitude(gain: number[]): number {
    let result = 0
    let index = 0
    let altitude = 0

    while(index < gain.length){
        const item = gain[index]
        altitude+=item
        result = Math.max(altitude, result)
        index++
    }

    return result
};


console.log(largestAltitude([-5,1,5,0,-7]))