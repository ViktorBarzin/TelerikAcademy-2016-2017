function solve(args) {
    var n = +args[0],
        i,
        j,
        result = '';

    for (i = 1; i <= n; i += 1) {
        for (j = i; j < n + i; j += 1) {
            result += j + ' ';
        }
        console.log(result);
        result = '';
    }
}