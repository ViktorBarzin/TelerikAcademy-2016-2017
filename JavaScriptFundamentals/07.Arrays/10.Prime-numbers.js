function solve(args) {
    var n = +args[0],
        i,
        len;
    
    for(i = n; i >= 0; i--){
        if (isPrime(i)) {
            console.log(i);
            break;
        }
    }
    
    function isPrime(number) {
        for(j = 2; j <  number ; j+=1){
            if (number % j === 0) {
                return false;
            }
        }
        
        return true;
    }
}