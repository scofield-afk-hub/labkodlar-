Console.WriteLine("Enter the First number ");
double number = double.Parse(Console.ReadLine());

Console.WriteLine("Enter the Second number ");
double number2 = double.Parse(Console.ReadLine());

double addition = number + number2;
Console.WriteLine($"{number} + {number2}= {addition}");

double subtraction = number - number2;
Console.WriteLine($"{number} - {number2} = {subtraction}");

double multiplication = number * number2;
Console.WriteLine($"{number} * {number} = {multiplication}");

double divide = number / number2;
Console.WriteLine($"{number} / {number2} = {divide}");
