function solve(args) {
    function moveThroughValley(array, pattern) {
        var index = 0,
            patternIndex = 0,
            visited = [],
            currentSum = 0;

        while (!visited[index] && array[index] !== undefined) {
            visited[index] = true;
            currentSum += array[index];
            index += pattern[patternIndex];
            patternIndex = (patternIndex + 1) % pattern.length;
        }

        return currentSum;
    }

    var valley = args[0].split(', ').map(Number),
        m = +args[1],
        patterns = [],
        i = 0,
        maxSum = 0;

    for (i = 0;i < m; i += 1) {
        patterns.push(args[i + 2].split(', ').map(Number));
    }

    for (i = 0, len = patterns.length; i < len; i += 1) {
        tempSum = moveThroughValley(valley, patterns[i]);
        console.log(tempSum);
        if (tempSum > maxSum) {
            maxSum = tempSum;
        }
    }

    console.log(maxSum);
}


var input = ['1, 3, -6, 7, 4 ,1, 12',
    '3',
    '1, 2, -3',
    '1, 3, -2',
    '1, -1'];

solve(input);