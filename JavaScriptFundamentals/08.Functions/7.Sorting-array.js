function solve(args) {
    var input = args[0].split('\n'),
        n = +input[0],
        numbers = input[1].split(' ').map(Number);

    if (numbers.length > 1) {
        console.log(numbers.sort(function (x, y) {
            return x - y;
        }).join(' '));
    }
}