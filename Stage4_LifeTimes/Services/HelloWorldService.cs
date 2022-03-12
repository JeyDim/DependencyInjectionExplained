namespace Stage4_LifeTimes.Services;

internal class HelloWorldService
{
    private readonly int _random;
    private readonly ConsoleService _service;
    public HelloWorldService(ConsoleService service)
    {
        _service = service;
        _random = new Random().Next();
    }

    public void SayHello()
    {
        _service.Print($"hw_{_random} Hello World!");
    }
}
