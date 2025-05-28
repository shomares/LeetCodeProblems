
const hashmap = new Set<number>()

function findCircleNumRecursive(map: Map<number, number[]>, height: number, index: number): boolean {

    if (hashmap.has(index) && height > 0) {
        return true
    }

    if (hashmap.has(index)) {
        return false
    }

    hashmap.add(index)
    const values = map.get(index)

    if (values.length === 0) {
        return false
    }

    let result = false
    for (let item of values) {
        result = findCircleNumRecursive(map, height + 1, item)
    }

    return result
}



function findCircleNum(isConnected: number[][]): number {
    const map = new Map<number, number[]>()
    hashmap.clear()

    for (let indexi = 0; indexi < isConnected.length; indexi++) {
        const array: number[] = []
        for (let indexj = 0; indexj < isConnected[indexi].length; indexj++) {
            const value = isConnected[indexi][indexj]
            if (indexi !== indexj && value === 1) {
                array.push(indexj)
            }
        }

        map.set(indexi, array)
    }

    let count = 0

    for (let item of map.keys()) {
        const value = map.get(item)

        if(value.length === 0){
            count++
            continue
        }

        const res = findCircleNumRecursive(map, 0, item)

        if (res) {
            count++
        }
    }

    return count
};


/*
console.log(findCircleNum([
    [1, 1, 1, 1],
    [1, 1, 0, 0],
    [1, 0, 1, 0],
    [1, 0, 0, 1]

]))
    */



console.log(findCircleNum([[1, 1, 0], [1, 1, 0], [0, 0, 1]]))