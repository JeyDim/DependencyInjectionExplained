var consoleService = Activator.CreateInstance<ConsoleService>();
var helloWorldService = (HelloWorldService)Activator.CreateInstance(typeof(HelloWorldService), consoleService);
var consumerService = (ConsumerService)Activator.CreateInstance(typeof(ConsumerService), helloWorldService);

consumerService.Print();
