namespace LD.Shared;

public class DvdPlayer : IPlayable
{
    public void Pause()
    {
        WriteLine("DVD players is pausing.");
    }

    public void Play()
    {
        WriteLine("DVD Player is playing");
    }
}