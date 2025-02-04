//1,1,2,2,2,3

function frequencySort(nums: number[]): number[] {

    const mapFrequency = new Map<number, number>();

    for (let number of nums) {
        if (mapFrequency.has(number)) {
            mapFrequency.set(number, mapFrequency.get(number) + 1);
        } else {
            mapFrequency.set(number, 1);
        }
    }

    nums.sort((a, b) => {
        const fa = mapFrequency.get(a);
        const fb = mapFrequency.get(b);

        if (fa == fb) {
            return b - a;
        }

        return fa - fb;
    });
    return nums;

};

