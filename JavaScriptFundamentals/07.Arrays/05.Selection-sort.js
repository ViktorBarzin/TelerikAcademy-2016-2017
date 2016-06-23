function solve(args) {
    var input = args[0].split('\n'),
        n = +input[0],
        min,
        len,
        i;
    input.shift();
    // TODO : fix 40/100
    input.forEach(function parse(item) {
        item = +item;
    });
    
    for (i = 0,len = input.length; i < len; i += 1) {
        min = getMinElement(input,i);
        replaceItems(input, i, input.indexOf(min));
    }
    console.log(input.join('\n'));

    function replaceItems(array,firstIndex, secondIndex) {
        var temp = array[firstIndex];
        array[firstIndex] = array[secondIndex];
        array[secondIndex] = temp;
    }
    
    function getMinElement(array,startIndex) {
        var minElement = array[startIndex],
        arrayLen = array.length;
        for(j = startIndex; j <  arrayLen; j+=1){
            if (minElement > array[j]) {
                minElement = array[j];
            }
        }
        
        return minElement;
    }
    
}

solve(['6\n3\n4\n1\n5\n2\n6']);