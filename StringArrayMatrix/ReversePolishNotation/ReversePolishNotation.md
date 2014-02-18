Reverse Polish notation (RPN) is a mathematical notation in which every operator follows all of its operands, in contrast to Polish notation, which puts the operator in the prefix position. It is also known as postfix notation and is parenthesis-free as long as operator arities are fixed. 

The description "Polish" refers to the nationality of logician Jan Łukasiewicz, who invented (prefix) Polish notation in the 1920s.

# Algorithm #


* While there are input tokens left
  * Read the next token from input.
  * If the token is a value
     * Push it onto the stack.
  * Otherwise, the token is an operator (operator here includes both operators and functions).
    * It is known a priori that the operator takes n arguments.
    * If there are fewer than n values on the stack
      * (Error) The user has not input sufficient values in the expression.
    * Else, Pop the top n values from the stack.
    * Evaluate the operator, with the values as arguments.
    * Push the returned results, if any, back onto the stack.
* If there is only one value in the stack
  * That value is the result of the calculation.
* Otherwise, there are more values in the stack
  * (Error) The user input has too many values.

# Example #
5 1 2 + 4 * + 3 -

<table>
<tr>
<th>Input</th>
<th>Operation</th>
<th>Stack</th>
<th>Comment</th>
</tr>
<tr>
<td>5</td>
<td>Push value</td>
<td>5</td>
<td></td>
</tr>
<tr>
<td>1</td>
<td style="vertical-align: top;">Push value</td>
<td>1<br />
5</td>
<td></td>
</tr>
<tr>
<td>2</td>
<td style="vertical-align: top;">Push value</td>
<td>2<br />
1<br />
5</td>
<td></td>
</tr>
<tr>
<td>+</td>
<td style="vertical-align: top;">Add</td>
<td>3<br />
5</td>
<td>Pop two values (1, 2) and push result (3)</td>
</tr>
<tr>
<td>4</td>
<td style="vertical-align: top;">Push value</td>
<td>4<br />
3<br />
5</td>
<td></td>
</tr>
<tr>
<td>*</td>
<td style="vertical-align: top;">Multiply</td>
<td>12<br />
5</td>
<td>Pop two values (3, 4) and push result (12)</td>
</tr>
<tr>
<td>+</td>
<td style="vertical-align: top;">Add</td>
<td>17</td>
<td>Pop two values (5, 12) and push result (17)</td>
</tr>
<tr>
<td>3</td>
<td style="vertical-align: top;">Push value</td>
<td>3<br />
17</td>
<td></td>
</tr>
<tr>
<td>−</td>
<td style="vertical-align: top;">Subtract</td>
<td>14</td>
<td>Pop two values (17, 3) and push result (14)</td>
</tr>
<tr>
<td></td>
<td>Result</td>
<td>(14)</td>
<td></td>
</tr>
</table>