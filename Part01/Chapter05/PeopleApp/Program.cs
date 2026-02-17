using System.ComponentModel;
using System.Diagnostics;
using LD.Shared;
using Dumpify;
using System.Collections.ObjectModel;

ConfigureConsole(useComputerCulture: true);

#region Using OOP
Person bob = new();
WriteLine(bob);
bob.Name = "Lego Man";
bob.Born = new DateTimeOffset(
    year: 1965,
    month: 12,
    day: 22,
    hour: 16,
    minute: 28,
    second: 0,
    offset: TimeSpan.FromHours(-6)); // The last one is a really off way to set the timezone
WriteLine($"{bob.Name} was born on {bob.Born:D}");

// Creating object a different way
Person alice = new()
{
    Name = "Alice Jones",
    Born = new(1990, 3, 7, 16, 28, 0, TimeSpan.Zero)
};
WriteLine($"{alice.Name} was born {alice.Born:d}.");
#endregion

#region Using Enum
bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusOfOlympia;
WriteLine($"{bob.Name} favorite Wondes is {bob.FavoriteAncientWonder}.");

bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon |
                WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
WriteLine($"{bob.Name}'s bucketlist is {bob.BucketList}");
#endregion

#region Using Collections
Person alfred = new();
alfred.Name = "Alfred";
bob.Children.Add(alfred);
bob.Children.Add(new Person {Name = "Bella"});
bob.Children.Add(new() {Name = "Zoe"});
WriteLine($"{bob.Name} has {bob.Children.Count}");
for (int childIndex = 0; childIndex < bob.Children.Count; childIndex++)
{
    WriteLine($"> {bob.Children[childIndex].Name}");
}
#endregion

#region  Using static members on BankAccount example
BankAccount.InterestRate = 0.012M;
BankAccount jonesAccount = new();
jonesAccount.AccountName = "Mr. Jones";
jonesAccount.Balance = 2400;
WriteLine($"{jonesAccount.AccountName} earned {jonesAccount.Balance * BankAccount.InterestRate:C}");
BankAccount gerrierAccount = new();
gerrierAccount.AccountName = "Ms. Gerrier";
gerrierAccount.Balance = 98;
WriteLine($"{gerrierAccount.AccountName} earned {gerrierAccount.Balance * BankAccount.InterestRate:C}");
#endregion

#region Using const value species example
    WriteLine($"{bob.Name} is a {Person.Species}");
#endregion

#region Using read-only field
    WriteLine($"{bob.Name} was born on {bob.HomePlanet}");
#endregion

#region Using Dumpify
    bob.Dump(label: "Default output");
    bob.Dump(label: "Include Fields and non-public members",
    members: new MembersConfig {IncludeFields = true,
    IncludeNonPublicMembers = true});
#endregion

#region Using modern Library
    Book book = new()
    {
        Isbn = "978-18032373567",
        Title = "The Fox, The Mole, The Horse and The Boy"
    };
    WriteLine($"{book.Isbn} : {book.Title} written by {book.Author} has {book.PageCount:N0} pages");
#endregion

#region Constructor initialize
Person blankPerson = new();
WriteLine($"{blankPerson.Name} of {blankPerson.HomePlanet} was created at {blankPerson.Instantiated:hh:mm:ss}");

Person gunny = new(initialName: "Gunny", homePlanet: "Mars");
WriteLine($"{gunny.Name} of {gunny.HomePlanet} was created at {gunny.Instantiated:hh:mm:ss} on a {gunny.Instantiated:dddd}");

Book book2 = new(isbn: "978-392394201321", title:"GOG")
{
    Author = "Giovanni Papini",
    PageCount = 148
};
 WriteLine($"{book2.Isbn} : {book2.Title} written by {book2.Author} has {book2.PageCount:N0} pages");
#endregion

#region Methods calls
    bob.WriteToConsole();
    WriteLine(bob.GetOrigin());
    WriteLine(bob.SayHello());
    WriteLine(bob.SayHelloTo("Emily"));
    WriteLine(bob.OptionalParameters());
    WriteLine(bob.OptionalParameters("Jump!", 98.5));
#endregion