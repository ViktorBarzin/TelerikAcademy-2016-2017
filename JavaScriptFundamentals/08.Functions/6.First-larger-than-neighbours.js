function solve(args) {
    var input = args[0].split('\n'),
        n = +input[0],
        numbers = input[1].split(' ').map(Number),
        i,
        index;

    for (i = 1; i < n - 1; i += 1) {
        if (isBiggerThanNeighbours(numbers, i, i - 1, i + 1)) {
            index = i;
            break;
        }
    }

    console.log(index === -1 ? -1 : index);

    function isBiggerThanNeighbours(array, mid, left, right) {
        return array[mid] > array[left] && array[mid] > array[right];
    }
}