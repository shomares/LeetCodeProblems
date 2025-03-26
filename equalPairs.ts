function equalPairs(grid: number[][]): number {

    const hashSet = new Map<string, number>()
    let result = 0

    let index = 0
    let indexj = 0

    while (indexj < grid[0].length) {


        const valueToAdd = new Array<string>(grid.length)
        while (index < grid.length) {
            const value = grid[index][indexj]
            valueToAdd[index]= value.toString()
            index++
        }

        index = 0

        const toAddStr  = valueToAdd.join('_')

        if(hashSet.has(toAddStr)){
            hashSet.set(toAddStr, hashSet.get(toAddStr) + 1)
        }else{
            hashSet.set(toAddStr, 1)
        }

      
        indexj++
    }

    index = 0

    while(index < grid.length){
        indexj = 0

        const valueToCompare = new Array<string>(grid[index].length)
        while(indexj< grid[index].length){

            const value = grid[index][indexj]
            valueToCompare[indexj] = value.toString()
            indexj++
        }

        const strToCompare = valueToCompare.join('_')

        if(hashSet.has(strToCompare)){
            result+= hashSet.get(strToCompare)
        }

        index++
    }

    return result
};


console.log(equalPairs([[3,1,2,2],[1,4,4,4],[2,4,2,2],[2,5,2,2]]))