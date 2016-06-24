function solve(args) {
    var firstString = args[0].split('\n')[0],
        secondString = args[0].split('\n')[1];

    if (firstString > secondString) {
        console.log('>');
    } else if (firstString < secondString) {
        console.log('<');
    }
    else {
        console.log('=');
    }
}