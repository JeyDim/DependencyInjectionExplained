namespace Stage2_Activator.Services;

internal class ConsoleService: ICanSendMessage
{
    public void SendMessage(string message) => Console.WriteLine(message);
}
