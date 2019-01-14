using System;
using System.Collections.Generic;

namespace postfix_calculator
{
  class Program
  {
    // Postfix calculator implementation using Stack<int>
    // Example :
    //   infix notation: 5 + 2
    //   postfix notation 5 2 + (operators follow operands)
    // Run this with CLI: dotnet run -- 5 3 9 * + 2 / 6 -
    // Shoud return 10
    static void Main(string[] args)
    {
      Stack<int> stack = new Stack<int>();

      foreach (string token in args)
      {
        if (int.TryParse(token, out int value))
        {
          stack.Push(value);
        }
        else
        {
          int rightHandSide = stack.Pop();
          int leftHandSide = stack.Pop();
          int result;

          switch (token)
          {
            case "*":
              result = leftHandSide * rightHandSide;
              break;
            case "/":
              result = leftHandSide / rightHandSide;
              break;
            case "%":
              result = leftHandSide % rightHandSide;
              break;
            case "+":
              result = leftHandSide + rightHandSide;
              break;
            case "-":
              result = leftHandSide - rightHandSide;
              break;
            default:
              throw new NotSupportedException("Unknown operator");
          }

          // push operation result to stack
          stack.Push(result);
        }

      }

      // Print result
      Console.WriteLine($"Result is: {stack.Pop()}");

      Console.Write("Press any key...");
      Console.ReadKey();
    }
  }
}
