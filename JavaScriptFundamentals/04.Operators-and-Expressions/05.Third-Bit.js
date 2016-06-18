function solve(args) {
    var toBinary = (args[0] * 1).toString(2),
        thirdBit = toBinary[toBinary.length - 4];

    if (toBinary.length >= 4) {
        console.log(thirdBit === '0' ? '0' : '1');
    } else {
        console.log(0);
    }
}