namespace Stage4_LifeTimes.Services;

internal class ConsoleService
{
    private readonly int _random;
    public ConsoleService()
    {
        _random = new Random().Next();
    }
    public void Print(string phrase) => Console.WriteLine($"c{_random} {phrase}");
}
