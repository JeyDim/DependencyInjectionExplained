namespace Stage4_LifeTimes.Services;

internal class ConsoleService: ICanSendMessage
{
    private readonly int _random;
    public ConsoleService()
    {
        _random = new Random().Next();
    }
    public void SendMessage(string message) => Console.WriteLine($"#CS{_random} {message}");
}
