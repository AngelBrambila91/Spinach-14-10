using System.Dynamic;

namespace LD.Shared;

public class Person : object
{
    public string? Name;
    public DateTimeOffset Born;
    public WondersOfTheAncientWorld FavoriteAncientWonder;
    public WondersOfTheAncientWorld BucketList;
    public List<Person> Children = [];
    // Constant string
    public const string Species = "Homo Sapiens";
    //Read-only fields: Values that can be set at runtime
    public readonly string HomePlanet = "Earth";
    public readonly DateTime Instantiated;

    // Initializing on constructor
    public Person()
    {
        // Constructors can set default values for fields
        Name = "Unkwown";
        Instantiated = DateTime.Now;
    }

    public Person (string initialName, string homePlanet)
    {
        Name = initialName;
        HomePlanet = homePlanet;
        Instantiated = DateTime.Now;
    }

    #region Methods
        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on a {Born:dddd}");
        }

        public string GetOrigin()
        {
            return $"{Name} was born on {HomePlanet}.";
        }

        public string SayHello()
        {
            return $"{Name} says Hello";
        }

        public string SayHelloTo(string name)
        {
            return $"{Name} says 'Hello, {name}!'";
        }

        public string OptionalParameters(string command = "Run!", double number = 0.0, bool active = true)
        {
            return string.Format($"command is {command}, number is {number}, active is {active}");
        }
    #endregion
}
