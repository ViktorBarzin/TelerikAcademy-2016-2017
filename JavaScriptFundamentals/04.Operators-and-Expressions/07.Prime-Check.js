function solve(args) {
    var number = +args[0]
    console.log(isPrime(number) && number >= 0 ? 'true' : 'false');

    function isPrime(number) {
        var index;
        for (index = 2; index < number; index++) {
            if (number % index === 0) {
                return false;
            }
        }

        return true;
    }
}