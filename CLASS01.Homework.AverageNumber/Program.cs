// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Task 2
//Create new console application “AverageNumber” that takes four numbers as input to calculate and print the average.

//Test Data:
//Enter the First number: 10
//Enter the Second number: 15
//Enter the third number: 20
//Enter the four number: 30
//Expected Output:
//The average of 10, 15, 20 and 30 is: 18

Console.WriteLine("Enter four numbers: ");

string num = Console.ReadLine();
string num1 = Console.ReadLine();
string num2 = Console.ReadLine();
string num3 = Console.ReadLine();

bool isValid = int.TryParse(num, out int numb);
bool isValid1 = int.TryParse(num1, out int numb1);
bool isValid2 = int.TryParse(num2, out int numb2);
bool isValid3 = int.TryParse(num3, out int numb3);

int averageNumber = ((numb + numb1 + numb2 + numb3) / 4);
Console.WriteLine("The average number is : " + averageNumber);