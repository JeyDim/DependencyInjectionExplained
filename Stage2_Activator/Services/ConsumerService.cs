namespace Stage2_Activator.Services;

internal class ConsumerService
{
    private readonly MessageService _messageService;
    public ConsumerService(MessageService messageService)
    {
        _messageService = messageService;
    }

    public void Print()
    {
        _messageService.SayHello();
    }
}
