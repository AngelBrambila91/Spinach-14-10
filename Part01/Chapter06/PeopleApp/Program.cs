using LD.Shared;
using Dumpify;

Person harry = new()
{
    Name = "Harry",
    Born = new(year: 2001, month: 3, day: 25, hour: 0, minute: 0, second: 0, offset: TimeSpan.Zero)
};
harry.WriteToConsole();

Person mort = new() { Name = "Mort" };
Person ada = new() { Name = "Ada" };
Person sila = new() { Name = "Sila" };
Person leon = new() { Name = "Leon" };
Person kindle = new() { Name = "Kindle" };
// Call the instance method to marry the first 2
mort.Marry(ada);
// Call the static method to marry the frist one and the third one
Person.Marry(mort, sila);
// Show spouses
mort.OutputSpouses();
ada.OutputSpouses();
sila.OutputSpouses();
// Call instance to make a baby
Person baby1 = mort.ProcreateWith(ada);
baby1.Name = "Tadela";
// Call static method to make a baby
Person baby2 = Person.Procreate(mort, sila);
baby2.Name = "Wong";

// Using operators to marry and procreate
//Using +
if(leon + kindle)
{
    WriteLine($"{leon.Name} and {kindle.Name} successfully got married.");
}
// Using *
Person baby3 = leon * kindle;
baby3.Name = "Kenedy";
Person baby4 = mort * sila;
baby4.Name = "Juan";

ada.WriteChildrenToConsole();
sila.WriteChildrenToConsole();
mort.WriteChildrenToConsole();

for (int i = 0; i < mort.Children.Count; i++)
{
    WriteLine($" {mort.Name}'s child #{i} is named \"{mort.Children[i].Name}\".");
}

mort.Dump();

// Non-Generic lookup Collection
System.Collections.Hashtable lookupObject = new();
lookupObject.Add(key: 1, value: "Alpha");
lookupObject.Add(key: 2, value: "Beta");
lookupObject.Add(key: 3, value: "Gamma");
lookupObject.Add(key: harry, value: "Delta");

int key = 2;
WriteLine($"Key {key} has value: {lookupObject[key]}");
// Lookup for value harry
WriteLine($"Key {harry} has value: {lookupObject[key]}");

//Define a generic lookup Collection Dictionary
Dictionary<int, string> lookupIntString = new();
lookupIntString.Add(key: 1, value: "Alpha");
lookupIntString.Add(key: 2, value: "Beta");
lookupIntString.Add(key: 3, value: "Gamma");
lookupIntString.Add(key: 4, value: "Delta");

key = 3;
WriteLine($"Key {key} has value: {lookupIntString[key]}");

// Assign the method to the shout delegate
harry.Shout += Harry_Shout;
harry.Shout += Harry_Shout_2;
// Call the poke method that eventually raises the shout event
harry.Poke();
harry.Poke();
harry.Poke();
harry.Poke();

Person?[] people =
{
    new() { Name = "Simon" },
    new() { Name = "Jenny" },
    new() { Name = "Adam" },
    new() { Name = "null" },
    new() { Name = "Richard" },
};

OutputPeopleNames(people, "Initial list of people:");
Array.Sort(people);
OutputPeopleNames(people, "Ordered list of people using IComparable:");