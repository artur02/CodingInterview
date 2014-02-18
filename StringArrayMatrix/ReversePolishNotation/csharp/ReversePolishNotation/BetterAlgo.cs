using System;
using System.Collections.Generic;
using Xunit;

namespace ReversePolishNotation
{
    public class BetterAlgo
    {
        public int Execute(IEnumerable<string> tokens)
        {
            const string operators = "+-*/";
            var stack = new Stack<int>();

            foreach (var token in tokens)
            {
                if (operators.IndexOf(token, StringComparison.Ordinal) == -1)
                {
                    stack.Push(Convert.ToInt32(token));
                }
                else
                {
                    var a = stack.Pop();
                    var b = stack.Pop();

                    switch (token)
                    {
                        case "+":
                            stack.Push(b + a);
                            break;
                        case "-":
                            stack.Push(b - a);
                            break;
                        case "*":
                            stack.Push(b * a);
                            break;
                        case "/":
                            stack.Push(b / a);
                            break;
                    }
                }

                Console.WriteLine("token: {0}, stack: {1}", token, String.Join(" ", stack.ToArray()));
            }

            return stack.Pop();
        }
    }

    public class BetterAlgoTests
    {
        readonly BetterAlgo algo = new BetterAlgo();

        [Fact]
        public void Sample1()
        {
            var data = new[] { "2", "1", "+", "3", "*" };

            var result = algo.Execute(data);

            Assert.Equal(9, result);
        }

        [Fact]
        public void Sample2()
        {
            var data = new[] { "4", "13", "5", "/", "+" };

            var result = algo.Execute(data);

            Assert.Equal(6, result);
        }
    }
}
