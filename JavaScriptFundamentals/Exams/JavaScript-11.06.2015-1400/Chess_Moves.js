function solve(params) {
    var rows = +params[0]
    var cols = +params[1]
    var chess_board = [,]

    //Fill matrix
    for (var row = 0; row < rows; row += 1) {
        chess_board[row] = new Array()
        for (var col = 0; col < cols; col += 1) {
            chess_board[row][col] = params[row + 2][col]
        }
    }


}

// Todo : check multidimensional arrays indexing
function isPathClear(board, start, end, type) {
    switch (type) {
        case 'R':
            // Rook move
            // Check if we should move on X
            if(start[0] < end[0] || start[0] >= end[0]){
                var delta = start[0] > end[0] ? -1 : 1
                while (start[0] != end[0]) {
                    if(board[start] !== '-'){
                        return false;
                    }
                    start[0]+= delta
                }
                if (board[start] === '-') {
                    return true;
                }
                
                return false;
            }
            // Check if we should move on Y
            else if(start[1] < end[1] || start[1] >= end[1]){
                
            }
            break;
        case 'B':
            // Bishop move
            
            break;
        case 'Q':
            break;
        default:
            break;

    }
}

/*3
4
--RB--B
Q--Q
 */
solve(process.argv.slice(2))