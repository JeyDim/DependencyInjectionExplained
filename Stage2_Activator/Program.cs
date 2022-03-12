// var consoleService = new ConsoleService();
// var helloWorldService = new HelloWorldService(consoleService);
// var consumerService = new ConsumerService(helloWorldService);

var consoleService = Activator.CreateInstance<ConsoleService>();
var helloWorldService = (HelloWorldService)Activator.CreateInstance(typeof(HelloWorldService), consoleService);
var consumerService = (ConsumerService)Activator.CreateInstance(typeof(ConsumerService), helloWorldService);

consumerService.Print();
