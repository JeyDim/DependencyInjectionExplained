var consoleService = Activator.CreateInstance<ConsoleService>();
var helloWorldService = (MessageService)Activator.CreateInstance(typeof(MessageService), consoleService);
var consumerService = (ConsumerService)Activator.CreateInstance(typeof(ConsumerService), helloWorldService);

consumerService.Print();
