function solve(params) {
    var nk = params[0].split(' ')
    var numbersCount = nk[0]
    var numberOfTransformations = nk[1]

    var numbers = params[1].split(' ')
    var transformed = []

    for (var i = 0; i < numbersCount; i += 1) {
        numbers[i] = +numbers[i]
        transformed[i]= numbers[i]
    }

    for (var k = 0; k < numberOfTransformations; k += 1) {
        for (var index = 0; index < numbersCount; index+=1) {
            // If number is 0            
            if (numbers[index] == 0) {
                if (index == 0) {
                    transformed[0] = Math.abs(numbers[numbersCount - 1] - numbers[1])
                }
                else if (index + 1 == numbersCount) {
                    transformed[index] = Math.abs(numbers[index - 1] - numbers[0])
                }
                else {
                    transformed[index] = Math.abs(numbers[index - 1] - numbers[index + 1])
                }
            }
            // If numbers is even
            else if (numbers[index] % 2 == 0) {
                if (index == 0) {
                    transformed[0] = Math.max(numbers[numbersCount - 1], numbers[1])
                }
                else if (index + 1 == numbersCount) {
                    transformed[index] = Math.max(numbers[index - 1], numbers[0])
                }
                else {
                    transformed[index] = Math.max(numbers[index - 1], numbers[index + 1])
                }
            }
            // If numbers is 1 
            else if (numbers[index] == 1) {
                if (index == 0) {
                    transformed[0] = Math.abs(numbers[numbersCount - 1] + numbers[1])
                }
                else if (index + 1 == numbersCount) {
                    transformed[index] = Math.abs(numbers[index - 1] + numbers[0])
                }
                else {
                    transformed[index] = Math.abs(numbers[index - 1] + numbers[index + 1])
                }
            }
            // If number is odd
            else if (numbers[index] % 2 == 1) {
                if (index == 0) {
                    transformed[index] = (Math.min(numbers[numbersCount - 1], numbers[1]))
                }
                else if (index + 1 == numbersCount) {
                    transformed[index] = Math.min(numbers[index - 1], numbers[0])
                }
                else {
                    transformed[index] = Math.min(numbers[index - 1], numbers[index + 1])
                }
            }
        }
        // Refill initial array
            for(var i = 0; i < numbersCount;i +=1){
                numbers[i] = transformed[i]
            }
    }

    console.log(transformed.reduce(function(a, b) { return a + b; }, 0))
}
