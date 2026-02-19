using System.ComponentModel;
using LD.Shared;

int thisCannotBeNull = 4;
//thisCannotBeNull = null; // Compiler error
WriteLine(thisCannotBeNull);
int? thisCouldBeNull = null;
WriteLine(thisCouldBeNull);
WriteLine(thisCouldBeNull.GetValueOrDefault());
thisCouldBeNull = 7;
WriteLine(thisCouldBeNull);
WriteLine(thisCouldBeNull.GetValueOrDefault());

Address address = new(city: "London")
{
    Building = null,
    Street = null!,
    Region = "UK"
};

WriteLine(address.Building?.Length);
if(address.Street is not null)
{
WriteLine(address.Street.Length);
}