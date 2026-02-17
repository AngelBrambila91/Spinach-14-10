#region Unary operators

using System.Diagnostics.CodeAnalysis;

int a = 3;
int b = a++;
WriteLine($"a is {a}, b is {b}");
int c = 3;
int d = ++c; //Prefix means increment c before
WriteLine($"c is {c}, d is {d}");
#endregion

#region Binary operators
int e = 11;
int f = 3;
WriteLine($"e is {e}, f is {f}");
WriteLine($"e + f = {e + f}");
WriteLine($"e - f = {e - f}");
WriteLine($"e * f = {e * f}");
WriteLine($"e / f = {e / f}");
WriteLine($"e % f = {e % f}");
double g = 11.0;
WriteLine($"g is {g:N1}, f is {f}");
WriteLine($"g / f = {g / f}");
#endregion

#region Assigment Operators
int p = 6;
p += 3; // Equivalent to : p = p + 3
p -= 3; // Equivalent to : p = p - 3
p *= 3; // Equivalent to : p = p * 3
p /= 3; // Equivalent to : p = p / 3
#endregion

#region Null-Coalescing operators
// ? checks if it's either a string or a null
string? authorName = GetAuthorName();

// Check the length of a variable
// max Length will be the length of the author name or 30 if it's null
int maxLength = authorName?.Length ?? 30;

// The name will be unknown if the Name was null
authorName ??= "unkwown";

string? GetAuthorName()
{
    return null;
}
#endregion

#region Null-conditional assignment operator
// public class Customer
// {
//     public string Name { get; set; }
//     public int Age { get; set; }
//     public static void UpdateAge(Customer? customer, int newAge)
//     {
//         // This was an old fashioned way to check for nulls
//         // if(customer is not null)
//         // {
//         //     customer.Age = newAge;
//         // }
//         // Now we can use this
//         customer?.Age = newAge;
//         // If the customer is not null, Age will be updated.
//         // If the customer is null, nothing happen.
//     }
// }
#endregion

#region Logical Operators
bool q = true;
bool r = false;
WriteLine($"AND | q | r");
WriteLine($"q | {q & q,-5} | {q & r, -5}");
WriteLine($"r | {r & q,-5} | {r & r, -5}");
WriteLine();
WriteLine($"OR | q | r");
WriteLine($"q | {q | q,-5} | {q | r, -5}");
WriteLine($"r | {r | q,-5} | {r | r, -5}");
WriteLine();
WriteLine($"XOR | q | r");
WriteLine($"q | {q ^ q,-5} | {q ^ r, -5}");
WriteLine($"r | {r ^ q,-5} | {r ^ r, -5}");
WriteLine();
#endregion

#region Conditional Logical operators

#endregion