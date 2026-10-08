Console.WriteLine("What is your name? ");
string name = Console.ReadLine() ?? "";
Console.WriteLine("Which city are you from? ");
string city = Console.ReadLine() ?? "";
Console.WriteLine("What is your department? ");
string department = Console.ReadLine() ?? "";
Console.WriteLine("Which year ? ");
string year = Console.ReadLine() ?? "";

Console.WriteLine($"Name= {name}");
Console.WriteLine($"City= {city}");
Console.WriteLine($"Department={department}");
Console.WriteLine("C# is fun");
Console.WriteLine($"Hello {name} from {city}, welcome to C# ");
