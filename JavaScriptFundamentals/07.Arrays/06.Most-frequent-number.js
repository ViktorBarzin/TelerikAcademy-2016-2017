function solve(args) {
    var input = args[0].split('\n'),
        n = +input[0],
        result = {},
        numbers = input.slice(1),
        i,
        len;

    parseToNumber(numbers);
    for (i = 0; i < n; i += 1) {
        if (!result[numbers[i]]) {
            result[numbers[i]] = 1;
        } else {
            result[numbers[i]]++;
        }
    }

    maxElement = Object.keys(result).sort(function (a, b) { return result[a] - result[b]; }).reverse()[0];
    console.log(maxElement + ' (' + result[maxElement] + ' times)');

    function parseToNumber(array) {
        array.forEach(function parse(item) {
            item = +item;
        });
    }
}