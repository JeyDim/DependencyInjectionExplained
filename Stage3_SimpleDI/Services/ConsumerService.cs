namespace Stage3_SimpleDI.Services;

internal class ConsumerService
{
    private readonly HelloWorldService _helloWorldService;
    public ConsumerService(HelloWorldService helloWorldService)
    {
        _helloWorldService = helloWorldService;
    }

    public void Print()
    {
        _helloWorldService.SayHello();
    }
}
