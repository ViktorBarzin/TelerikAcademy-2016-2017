function solve(args) {
    var number = args[0];
    console.log(getLastDigitAsEnglishWord(+number[number.length-1]));
    
    function getLastDigitAsEnglishWord(number) {
        switch (number) {
            case 1:
                return 'one';
            case 2:
                return 'two';
            case 3:
                return 'three';
            case 4:
                return 'four';
            case 5:
                return 'five';
            case 6:
                return 'six';
            case 7:
                return 'seven';
            case 8:
                return 'eight';
            case 9:
                return 'nine';
            case 0:
                return 'zero';
        }
    }
}