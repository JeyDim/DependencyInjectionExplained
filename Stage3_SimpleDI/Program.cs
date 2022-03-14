using Stage2_Activator.Services;

var dependencyContainer = new DependencyContainer();

dependencyContainer.AddDependency<ICanSendMessage, ConsoleService>();
dependencyContainer.AddDependency<MessageService>();
dependencyContainer.AddDependency<ConsumerService>();

var dependencyResolver = new DependencyResolver(dependencyContainer);

var consoleService = dependencyResolver.GetService<ConsumerService>();


consoleService.Print();
