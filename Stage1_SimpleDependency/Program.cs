var consoleService = new ConsoleService();
var helloWorldService = new HelloWorldService(consoleService);
var consumerService = new ConsumerService(helloWorldService);

consumerService.Print();
