using System.Reflection; // To use assembly , Type Name and so on
// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// // #error version

#region Three variables that store the number 2 million
int decimalNotation = 2_000_000;
// int binaryNotation= 0b_0001_1110_1000_0100_1000_0000;
int hexadecimalNotation = 0x001E_8480;
#endregion

// Adding some unused variables
System.Data.DataSet ds = new();
HttpClient client = new();

// // Prefix @ to use a C# Keyword as a variable
// string @class = "A Poorly named variable";
// int @if = 5;

// // Using Write Line without Console because added statically on general System.Console
// WriteLine($"Computer named {Environment.MachineName} says \"No\"");

#region Assembly stuff
// Get the assembly that is the entry point for this app
Assembly? myApp = Assembly.GetEntryAssembly();
// If the previous line returned nothing then end the app
if(myApp is null) return;
// Loop trough the assemblies that my app references
foreach (AssemblyName name in myApp.GetReferencedAssemblies())
{
    // Load the assembly so we can read its details.
    Assembly a = Assembly.Load(name);
    // Declare variable to count the number of methods;
    int methodCount = 0;
    // Loop trough all the types in the assembly
    foreach (TypeInfo t in a.DefinedTypes)
    {
        // Add upo the counts of all methods
        methodCount += t.GetMethods().Length;
    }
    // Output the count of types and their methods.
    WriteLine("{0:N0} types with {1:N0} methods in {2} assembly",
    arg0: a.DefinedTypes.Count(),
    arg1: methodCount,
    arg2: name.Name);
}
#endregion