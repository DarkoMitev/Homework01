// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Task 1
//Create new console application “RealCalculator” that takes two numbers from the input 
//and asks what operation would the user want to be done ( +, - , * , / ).
//Then it returns the result.

//Test Data:
//Enter the First number: 10
//Enter the Second number: 15
//Enter the Operation: +
//Expected Output:
//The result is: 25

Console.WriteLine("Enter first number: ");
string num1 = Console.ReadLine();

Console.WriteLine("Enter second number: ");
string num2 = Console.ReadLine();

Console.WriteLine("Enter operation (+, -, *, /) :");
string operations = Console.ReadLine();

bool isValid = int.TryParse(num1, out int numb1);
bool isValid1 = int.TryParse(num2, out int numb2);

switch (operations)
{
    case "+":
        Console.WriteLine("The result is: " + (numb1 + numb2));
        break;

    case "-":
        Console.WriteLine("The result is: " + (numb1 - numb2));
        break;

    case "*":
        Console.WriteLine("The result is: " + (numb1 * numb2));
        break;
    case "/":
        Console.WriteLine("The result is: " + (numb1 / numb2));
        break;
    default:
        Console.WriteLine("You enterd wrong operator");
        break;
}
