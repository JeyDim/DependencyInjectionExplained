var dependencyContainer = new DependencyContainer();

dependencyContainer.AddDependency<ConsoleService>();
dependencyContainer.AddDependency<HelloWorldService>();
dependencyContainer.AddDependency<ConsumerService>();

var dependencyResolver = new DependencyResolver(dependencyContainer);

var consoleService = dependencyResolver.GetService<ConsumerService>();


consoleService.Print();
