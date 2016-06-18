function solve(args) {
    var a = +args[0],
        b = +args[1],
        c = +args[2],
        minusCounter = 0;

    if (a === 0 || b === 0 || c === 0) {
        console.log(0);
        return;
    } else {
        if (a.toString()[0] === '-') {
            minusCounter++;
        }
        if (b.toString()[0] === '-') {
            minusCounter++;
        }
        if (c.toString()[0] === '-') {
            minusCounter++;
        }
    }
    
    console.log(minusCounter % 2 === 0 ? '+' : '-');
}