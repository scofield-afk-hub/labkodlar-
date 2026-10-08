Console.WriteLine("Enter student name?");
string name = Console.ReadLine() ?? "";

Console.WriteLine("Enter midterm score?");
double midterm = double.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Enter final score?");
double final = double.Parse(Console.ReadLine() ?? "0");

double average = midterm * 0.4 + final * 0.6;
Console.WriteLine($"\n{name}, your average is {average:F2}");

if (average >= 50)
    Console.WriteLine("Result: PASSED");
else
    Console.WriteLine("Result: FAILED");

if (final == 100)
    Console.WriteLine("Perfect final!");