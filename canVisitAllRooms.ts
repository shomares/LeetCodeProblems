const hashSet = new Set<number>()


const canVisitAllRoomsRecursive = (room: number[], rooms: number[][])=> {
    if(room === null){
        return false
    }

    if(hashSet.size === rooms.length){
        return true
    }

    for(let index=0; index < room.length; index++){
        const value = room[index]

        if(hashSet.has(value)){
            continue
        }

        const toEvaluate = rooms[value]

        const result = canVisitAllRoomsRecursive(toEvaluate, rooms)

        if(!result){
           hashSet.delete(value)
        }else{
            return true
        }
    }
  
    return false
}

function canVisitAllRooms(rooms: number[][]): boolean {
    hashSet.clear()
    hashSet.add(0)
    return canVisitAllRoomsRecursive(rooms[0], rooms);
};


console.log(canVisitAllRooms([ [1, 3] , [1, 4] , [2, 3, 4, 1] , [ ] , [4, 3, 2] ]))