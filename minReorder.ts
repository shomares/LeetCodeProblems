
type MapOrder = {
    value: number,
    isOriginal: boolean
}

let result = 0

function minReorderRecursive(map: Map<number, MapOrder[]>, parent: number, key: number) {

    if (!map.has(key)) {
        return
    }

    const val = map.get(key)


    for (let index = 0; index < val.length; index++) {
        const valueArray = val[index]

        if (parent === valueArray.value) {
            continue
        }

        if (valueArray.isOriginal) {
            result++
        }

        minReorderRecursive(map, key, valueArray.value)
    }
}

function minReorder(n: number, connections: number[][]): number {
    const map = new Map<number, MapOrder[]>()

    for (let index = 0; index < connections.length; index++) {

        const key = connections[index][0]
        const value = connections[index][1]

        if (map.has(key)) {
            const array = map.get(key)
            array.push({
                isOriginal: true,
                value
            })
            map.set(key, array)
        } else {
            map.set(key, [{
                isOriginal: true,
                value
            }])
        }



        if (map.has(value)) {
            const array = map.get(value)
            array.push({
                isOriginal: false,
                value: key
            })
            map.set(value, array)
        } else {
            map.set(value, [{
                isOriginal: false,
                value: key
            }])
        }
    }


    //start dfs----------------------------------------------
    result = 0

    minReorderRecursive(map, undefined, 0)


    return result
};

console.log(minReorder(6, [[1, 0], [1, 2], [3, 2], [3, 4]]))