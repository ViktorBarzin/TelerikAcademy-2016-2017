function solve(args) {
    var counter = +args[0],
        i,
        result = '';
    
    for(i = 1; i <= counter ; i++){
        result += (i + ' ');
    }
    
    console.log(result);
}