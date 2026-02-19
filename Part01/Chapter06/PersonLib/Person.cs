using System.Net.Http.Headers;

namespace LD.Shared;

public class Person : object, IComparable<Person?>
{
    #region Properties
        public string? Name {get; set;}
        public DateTimeOffset Born { get; set; }
        public List<Person> Children { get; set; } = new();
        // Allow multiple spouses
        public List<Person> Spouses { get; set; } = new();
        public bool Married => Spouses.Count > 0;
    #endregion

    #region Methods
        public void WriteToConsole()
        {
            WriteLine($"{Name} was bron on {Born:dddd}");
        }

        public void WriteChildrenToConsole()
        {
            string term = Children.Count == 1 ? "child" : "children";
            WriteLine($"{Name} has {Children.Count} {term}.");
        }

        // Static method to get married
        public static void Marry(Person p1, Person p2)
        {
            ArgumentNullException.ThrowIfNull(p1);
            ArgumentNullException.ThrowIfNull(p2);
            if(p1.Spouses.Contains(p2) || p2.Spouses.Contains(p1))
            {
                throw new ArgumentException(
                    string.Format($"{p1.Name} is already married to {p2.Name}")
                );
            }
            p1.Spouses.Add(p2);
            p2.Spouses.Add(p1);
        }

        public void Marry(Person partner)
        {
            Marry(this, partner); // "this" is the current person
        }

        public void OutputSpouses()
        {
            if(Married)
            {
                string term = Spouses.Count == 1 ? "person" : "people";
                WriteLine($"{Name} is married to {Spouses.Count} {term}:");
                foreach (Person spouse in Spouses)
                {
                    WriteLine($" {spouse.Name}");
                }
            }
            else
            {
                WriteLine($"{Name} is a singleton");
            }
        }

        /// <summary>
        /// Static method to multiply aka procreate and have a child together
        /// </summary>
        /// <param name="p1">Parent 1</param>
        /// <param name="p2">Parent 2</param>
        /// <returns>A person onject that is the child of Parent 1 and Parent 2</returns>
        public static Person Procreate(Person p1, Person p2)
        {
            ArgumentNullException.ThrowIfNull(p1);
            ArgumentNullException.ThrowIfNull(p2);
            if(!p1.Spouses.Contains(p2) && !p2.Spouses.Contains(p1))
            {
                throw new ArgumentException(string.Format($"{p1.Name} must be married to {p2.Name} to procreate with them"));
            }
            Person baby = new()
            {
                Name = $"Baby of {p1.Name} and {p2.Name}",
                Born = DateTimeOffset.Now
            };
            p1.Children.Add(baby);
            p2.Children.Add(baby);
            return baby;
        }

        //Instance method multiply
        public Person ProcreateWith(Person partner)
        {
            return Procreate(this, partner);
        }
    #endregion

    #region Operators
        // Define the operator + to marry
        public static bool operator +(Person p1, Person p2)
        {
            Marry (p1, p2);
            // Confirm they're bot married
            return p1.Married && p2.Married;
        }

        // Define the operator * to multiply (procreate)
        public static Person operator *(Person p1, Person p2)
        {
            // Return a reference to the baby that result from multiplying
            return Procreate(p1, p2);
        }
    #endregion

    #region Events
        // Delegate Field to define the event.
        public event EventHandler? Shout; // null initialy
        // DataField related to the event
        public int AngerLevel;
        // Method to trigger the event in certain conditions
        public void Poke()
        {
            AngerLevel++;
            if(AngerLevel < 3) return;
            // If something is listening to the event
            if(Shout is not null)
            {
                // then call the delegate to "raise" the event
                Shout(this, EventArgs.Empty);
            }
        }

    public int CompareTo(Person? other)
    {
        int position;
        if(other is not null)
        {
            if((Name is not null) && (other.Name is not null))
            {
                // If both Name values arenot null, then use string implementation CompareTo
                position = Name.CompareTo(other.Name);
            }
            else if ((Name is not null) && (other.Name is null))
            {
                position = -1; // This person precedes other Person
            }
            else if ((Name is null) && (other.Name is not null))
            {
                position = 1; // This Person follows Other Person
            }
            else
            {
                position = 0; // This and other are at the same position
            }
        }
        else if (other is null)
        {
            position = -1; // This person precedes other Person
        }
        else
        {
            position = 0;
        }
        return position;
    }
    #endregion
}
