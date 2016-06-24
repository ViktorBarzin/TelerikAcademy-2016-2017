function solve(args) {
    var input = args[0].split('\n'),
        n = +input[0],
        numbers = input[1].split(' ').map(Number),
        counter = 0,
        i;

    for (i = 1; i < n - 1; i += 1) {
        if (isBiggerThanNeighbours(numbers, i, i - 1, i + 1)) {
            counter += 1;
        }
    }

    console.log(counter);

    function isBiggerThanNeighbours(array, mid, left, right) {
        return array[mid] > array[left] && array[mid] > array[right];
    }
}