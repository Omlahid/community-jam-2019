let i = 1;
let end = 100;
let fizzWord = "fizz";
let buzzWord = "buzz";
let fizzOccurence = "";
let buzzOccurence = "";

while (i <= end) {
    let currentNumer = i;
    fizzOccurence = "";
    buzzOccurence = "";
    if (i%3 == 0) {
        fizzOccurence = fizzWord;
        currentNumer = "";
    }
    if (i%5 == 0) {
        buzzOccurence = buzzWord;
        currentNumer = "";
    }

    console.log(currentNumer + fizzOccurence + buzzOccurence)
    i++;
}

console.log("Programmed finished");