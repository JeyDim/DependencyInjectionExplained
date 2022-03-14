namespace Stage4_LifeTimes.Services;

internal class MessageService
{
    private readonly ICanSendMessage _service;
    private readonly int _random;
    public MessageService(ICanSendMessage service)
    {
        _service = service;
        _random = new Random().Next();
    }

    public void SayHello()
    {
        _service.SendMessage($"#MS{_random} Hello World!");
    }
}
