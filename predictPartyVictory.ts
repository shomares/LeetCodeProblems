function predictPartyVictory(senate: string): string {
    let timesD = 0;
    let timesR = 0;
    let index = 0;
    const queque = [...senate];
    if (senate.length <= 2) {
        return senate[0] === 'D' ? 'Dire' : "Radiant";
    }
    while (index < senate.length) {
        const c = senate[index];
        if (c === 'D') {
            timesD++;
        }
        else {
            timesR++;
        }
        index++;
    }
    if (timesR === 0 && timesD > 0) {
        return "Dire";
    }
    if (timesD === 0 && timesR > 0) {
        return "Radiant";
    }
    /*
        DDRRR
        DRRD
        RDD
        RD
        D
    */
    let lastItemRemoved = null;
    let lastItemRemovedR =0
    let lastItemRemovedD =0
    
    while (queque.length >= 1) {
        const c = queque.shift();
        if (lastItemRemoved === c ) {

            if(c==='R' && lastItemRemovedR> 0){
                lastItemRemovedR--
                continue;
            }

            if(c ==='D' && lastItemRemovedD > 0){
                lastItemRemovedD--
                continue
            }

            
            
        }
        if (timesD > 1 && c === 'D' && timesR <= 1) {
            return "Dire";
        }
        if (timesR > 1 && c === 'R' && timesD <= 1) {
            return "Radiant";
        }
        queque.push(c);
        if (timesD > 1 && c === 'D' && timesR > 1) {
            timesR--;
            lastItemRemoved = 'R';
            lastItemRemovedR++
        }
        if (timesR > 1 && c === 'R' && timesD > 1) {
            timesD--;
            lastItemRemoved = 'D';
            lastItemRemovedD++
        }
    }
    if (timesR > timesD) {
        return "Radiant";
    }
    return "Dire";
};


console.log(predictPartyVictory("DRDRR"))

/*RDD
   DR
   D

*/

/*
    DDRRR
    DRRD
    RDD
    RD
    D
*/

/*
DDRRR - the first D moves to the back and takes out the first R
DRRD - the first D moves to the back and takes out the first R
RDD - the first R moves to the back and takes out the first D
DR - the first (and only) D moves to the back and takes out the first (and only) R
D - D wins the vote.

*/ 