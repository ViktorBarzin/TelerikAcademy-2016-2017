function solve(args) {
    if ((args[0] + '').length < 3) {
        console.log("false 0");
    } else {
        console.log(args[0][(args[0] + "").length - 3] == 7 ? "true" : "false " + args[0][(args[0] + "").length - 3]);

    }
}