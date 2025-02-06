function canFormArray(arr: number[], pieces: number[][]): boolean {
    let index = 0
    const mapPieces = new Map<number, number[]>()
    const mapArr = new Map<number, boolean>()

    for(let num of arr){
        mapArr.set(num, true)
    }

    for (let piece of pieces) {
        mapPieces.set(piece[0], piece)
    }

    while (index < arr.length) {
        let item = arr[index]

        if (!mapPieces.has(item)) {
            index++
            continue
        }

        const arrToCompare = mapPieces.get(item)
        let indexj = 0

        while (indexj < arrToCompare.length) {
            const itemC = arrToCompare[indexj]
            item = arr[index]

            if (itemC != item) {
                break;
            }

            mapArr.delete(itemC)
            indexj++
            index++
        }

        if (indexj != arrToCompare.length) {
            return false
        }
    }

    return mapArr.size == 0
};

