namespace Stage2_Activator.Services;

internal class MessageService
{
    private readonly ICanSendMessage _service;
    public MessageService(ICanSendMessage service)
    {
        _service = service;
    }

    public void SayHello()
    {
        _service.SendMessage("Hello World!");
    }
}
