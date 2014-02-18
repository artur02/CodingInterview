function execute(tokens){
    var   operators = ['+', '-', '*', '/'],
            stack = [],
            token;
            
    tokens.forEach(function(token){
        if(operators.indexOf(token) == -1){
            stack.push(parseInt(token, 10));
        } else {
            a = stack.pop();
            b = stack.pop();
            
            switch (token)
            {
                case "+":
                    stack.push(b + a);
                    break;
                case "-":
                    stack.push(b - a);
                    break;
                case "*":
                    stack.push(b * a);
                    break;
                case "/":
                    stack.push(parseInt(b / a, 10));
                    break;
            }
        }
        console.log(token, stack);
    });

    return stack.pop();
}

var result1 = execute(["2", "1", "+", "3", "*"]);
console.log(result1);
var result2 = execute(["4", "13", "5", "/", "+"]);
console.log(result2);