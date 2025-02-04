
//[9,29,49,50] cbcd
function slowestKey(releaseTimes: number[], keysPressed: string): string {
    let maxTime = releaseTimes[0];
    let maxKey = keysPressed[0];
    let index = 1;

    while (index < releaseTimes.length) {
        const time = releaseTimes[index] - releaseTimes[index - 1];
        const key = keysPressed[index];

        if (time < maxTime) {
            index++;
            continue;
        }

        if (time == maxTime && maxKey > key) {
            index++;
            continue;
        }

        maxTime = time;
        maxKey = key;
        index++;
    }

    return maxKey;
};

