using LD.Shared;

partial class Program
{
    // A method to handle the shout event received by the harry object
    private static void Harry_Shout(object? sender, EventArgs e)
    {
        // If no sender , then do nothing
        if(sender is null) return;
        // if sender is not a person , then do nothing and return; else assign sender to p
        if(sender is not Person p) return;
        WriteLine($"{p.Name} is this angry: {p.AngerLevel}.");
    }

    // Another method to handle the event received  by the harry object
    private static void Harry_Shout_2(object? sender, EventArgs e)
    {
        WriteLine("Stop it!");
    }
}