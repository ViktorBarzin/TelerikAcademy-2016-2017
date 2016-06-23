
function solve(args) {
    var array = (args + '').split('\n').map(Number),
        n = +array[0],
        wantedNum = +array[array.length - 1],
        low = 0,
        high = n - 1,
        mid = ((high + low) / 2) | 0,
        wantedNumberIsFound = false;

    array.shift();
    array.pop();
    while (low <= high) {
        if (wantedNum === +array[mid]) {
            wantedNumberIsFound = true;
            console.log(mid);
            return;
        } else if (wantedNum < +array[mid]) {
            high = mid - 1;
            mid = ((high + low) / 2) | 0;
        } else if (wantedNum > +array[mid]) {
            low = mid + 1;
            mid = ((high + low) / 2) | 0;
        }
    }
    console.log('-1');
}