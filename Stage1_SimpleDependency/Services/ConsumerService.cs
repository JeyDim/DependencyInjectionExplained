namespace Stage1_SimpleDependency.Services;

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
