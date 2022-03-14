namespace Stage1_SimpleDependency.Services;

internal class ConsoleService: ICanSendMessage
{
    public void SendMessage(string message) => Console.WriteLine(message);
}
