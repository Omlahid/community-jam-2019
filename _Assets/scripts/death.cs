function fateDice() {
    let rolltimes = 10;
    let totalM4 = 0;
    let totalM3 = 0;
    let totalM2 = 0;
    let totalM1 = 0;
    let totalP0 = 0;
    let totalP1 = 0;
    let totalP2 = 0;
    let totalP3 = 0;
    let totalP4 = 0;
    let errors = 0;
    for (i = 0; i < rolltimes; i++) {
        let fullRoll = "[";
        let rollResult = 0;
        for (j = 0; j < 4; j++) {
            let roll = Math.floor(Math.random() * 3) - 1;
            rollResult += roll;
            if (roll < 0) {
                fullRoll += roll.toString() + " ";
            } else {
                fullRoll += " " + roll.toString() + " ";
            }
        }
        fullRoll += "]";
        if (rollResult < 0) {
            console.log(rollResult + " " + fullRoll);
        } else {
            console.log(" " + rollResult + " " + fullRoll);
        }
        switch (roll) {
            case -4:
                totalM4++;
                break;
            case -3:
                totalM3++;
                break;
            case -2:
                totalM2++;
                break;
            case -1:
                totalM1++;
                break;
            case 0:
                totalP0++;
                break;
            case 1:
                totalP1++;
                break;
            case 2:
                totalP2++;
                break;
            case 3:
                totalP3++;
                break;
            case 4:
                totalP4++;
                break;
        }
    }
}

function abilityScore() {
    let totalScore = 0;
    let lowestScore = 7;
    for (i = 0; i < 4; i++) {
        let roll = Math.floor(Math.random() * 6) + 1;
        if (roll < lowestScore) {
            lowestScore = roll;
        }
        totalScore += roll;
    }
    totalScore = totalScore - lowestScore;
    return totalScore;
}

let totalRollsToRoll = 100000000;

let distribution = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];

for (rolls = 0; rolls < totalRollsToRoll; rolls++) {
    distribution[abilityScore() - 3]++;
}

let prettyDistribution = "";

for(k = 0; k < distribution.length; k++) {
    let currentRollScore = k + 3;
    let percentageOfRolls = (distribution[k]/totalRollsToRoll)*100;
    prettyDistribution += currentRollScore + " rolled " + distribution[k] + " times (" + percentageOfRolls +"%).\n";
}

console.log(prettyDistribution)