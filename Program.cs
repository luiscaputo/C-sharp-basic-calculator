using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("==== C A L C U L A D O R A ====");

      float number1, number2;
      char operation;

      Console.WriteLine("Enter the first number: ");
      number1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Enter the second number: ");
      number2 = float.Parse(Console.ReadLine());

      Console.WriteLine("Enter the operation (+, -, *, /): \n");
      operation = char.Parse(Console.ReadLine());

      switch(operation) { 
        case '+':
          Console.WriteLine($"The sum of {number1} and {number2} is: {number1 + number2}");
          break;
        case '-':
          Console.WriteLine($"The difference between {number1} and {number2} is: {number1 - number2}");
          break;
        case '*':
          Console.WriteLine($"The product of {number1} and {number2} is: {number1 * number2}");
          break;
        case '/':
          if (number2 == 0) {
            Console.WriteLine("Error: Division by zero is not allowed.");
          } else {
            Console.WriteLine($"The quotient of {number1} and {number2} is: {number1 / number2}");
          }
          break;
        default:
          Console.WriteLine("Error: Invalid operation. Please use +, -, *, or /.");
          break;
      }
    }
  }
} 