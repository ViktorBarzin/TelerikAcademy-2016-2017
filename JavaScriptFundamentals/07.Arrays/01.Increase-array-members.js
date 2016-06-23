function solve(args) {
    var n = +args[0],
        numbers = [];

    for (i = 0; i < n; i += 1) {
        numbers[i] = i * 5;
    }

    numbers.forEach(function print(item) {
        console.log(item);
    });
}