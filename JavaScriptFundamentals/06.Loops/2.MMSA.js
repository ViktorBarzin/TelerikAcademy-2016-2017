function solve(args) {
    args = Array.prototype.slice.call(args);
    var min = +args[0],
        max = +args[0],
        average = 0,
        sum = 0,
        i;
    for (i = 0; i < args.length; i++) {
        args[i] = +args[i];
        if (args[i] < min) {
            min = args[i];
        }
        if (args[i] > max) {
            max = args[i];
        }
        sum += args[i];
    }

    if (args.length > 0) {
        average = sum / args.length;
    } else {
        average = 0;
    }
    console.log('min=' + min.toFixed(2));
    console.log('max=' + max.toFixed(2));
    console.log('sum=' + sum.toFixed(2));
    console.log('avg=' + average.toFixed(2));
}