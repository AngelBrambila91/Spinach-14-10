object height = 1.88; // Sotring a double in an object
object name = "Amir"; // Storing a string in an object

Console.WriteLine($"{name} is {height} meters tall.");

///int lenght1 = name.Length; // Compile error, object cannot inherit methods
int lenght2 = ((string)name).Length; // Casting to string
Console.WriteLine($"{name} has {lenght2} characters.");

// dynamic
dynamic something;
// Storing an array into a dynamic
something = new[] { 3, 5, 7 };
// Storing int to dynamic object
something = 12;
// Storing string to dynamic
something = "Ahmed";
// This compiles but throe an exception at run-time
Console.WriteLine($"The length of something is {something.Length}");
// Output the type of something variable
Console.WriteLine($"something is a {something.GetType()}");

// Formatting
int numberOfApples = 10;
decimal pricePerApple = 0.35M;
Console.WriteLine($"{numberOfApples} apples cost {pricePerApple * numberOfApples:C}");

string applesText = "Apples";
int applesCount = 1234;
string bananasText = "Bananas";
int bananasCount = 56789;
Console.WriteLine();
Console.WriteLine($"{"Name",-10}{"Count",-6}");
Console.WriteLine($"{applesText,-10}{applesCount,-6:N0}");
Console.WriteLine($"{bananasText,-10}{bananasCount,-6:N0}");