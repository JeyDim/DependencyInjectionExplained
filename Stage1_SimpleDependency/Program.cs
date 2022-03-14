var consoleService = new ConsoleService();
var helloWorldService = new MessageService(consoleService);
var consumerService = new ConsumerService(helloWorldService);

consumerService.Print();
