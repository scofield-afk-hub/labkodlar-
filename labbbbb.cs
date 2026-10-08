Console.Write("Enter a 3-digit number: ");
int number = int.Parse(Console.ReadLine()!);

if (number < 100 || number > 999)
    Console.WriteLine("Warning: not a 3-digit number.");

int hundreds = number / 100;
int tens = number / 10 % 10;
int ones = number % 10;

Console.WriteLine($"Hundreds: {hundreds}");
Console.WriteLine($"Tens: {tens}");
Console.WriteLine($"Ones: {ones}");
Console.WriteLine($"Sum of digits: {hundreds + tens + ones}");

if (number % 2 == 0)
    Console.WriteLine($"{number} is even");
else
    Console.WriteLine($"{number} is odd");

if (hundreds == ones)
    Console.WriteLine("First and last digits are the same");
else
    Console.WriteLine("First and last digits are different");