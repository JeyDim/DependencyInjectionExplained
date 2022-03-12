namespace Stage2_Activator.Services;

internal class HelloWorldService
{
    private readonly ConsoleService _service;
    public HelloWorldService(ConsoleService service)
    {
        _service = service;
    }

    public void SayHello()
    {
        _service.Print("Hello World!");
    }
}
