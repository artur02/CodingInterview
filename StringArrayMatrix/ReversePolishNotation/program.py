def execute(tokens):
    operators = { '+', '-', '*', '/' }
    stack = []
    
    for token in tokens:
        if token not in operators:
            stack.append(int(token))
        else:
            a, b = [stack.pop(), stack.pop()]
            
            if token == "+":
                stack.append(b+a)
            elif token == "-":
                stack.append(b-a)
            if token == "*":
                stack.append(b*a)
            elif token == "/":
                stack.append(b/a)
                
        print token, stack
        
    return stack.pop()
        
if __name__ == "__main__":
    result1 = execute(["2", "1", "+", "3", "*"])
    print "result1: {result}".format(result=result1)
    assert(result1==9)
    
    result2 = execute(["4", "13", "5", "/", "+"])
    print "result2: {result}".format(result=result2)
    assert(result2==6)