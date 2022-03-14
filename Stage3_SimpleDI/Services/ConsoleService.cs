using Stage2_Activator.Services;

namespace Stage3_SimpleDI.Services;

internal class ConsoleService: ICanSendMessage
{
    public void SendMessage(string message) => Console.WriteLine(message);
}
