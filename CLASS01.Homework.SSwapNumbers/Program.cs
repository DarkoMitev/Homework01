// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Task 3:
//Create new console application “SwapNumbers”. 
//Input 2 numbers from the console and then swap the values of the variables 
//so that the first variable has the second value and the second variable 
//the first value. Please find example below:

//Test Data:
//Input the First Number: 5
//Input the Second Number: 8
//Expected Output:
//After Swapping:
//First Number: 8
//Second Number: 5

Console.WriteLine("Input first number: ");
string num1 = Console.ReadLine();

Console.WriteLine("Input second number: ");
string num2 = Console.ReadLine();

bool isValid = int.TryParse(num1, out int numb1);
bool isValid1 = int.TryParse(num2, out int numb2);

(numb1, numb2) = (numb2, numb1);

Console.WriteLine("After swapping: ");
Console.WriteLine("First number: " + numb1);
Console.WriteLine("Second number: " + numb2);