var dependencyContainer = new DependencyContainer();

dependencyContainer.AddSingleton<ConsoleService>();
dependencyContainer.AddTransient<HelloWorldService>();
dependencyContainer.AddTransient<ConsumerService>();

var dependencyResolver = new DependencyResolver(dependencyContainer);

var service1 = dependencyResolver.GetService<ConsumerService>();
service1.Print();
var service2 = dependencyResolver.GetService<ConsumerService>();
service2.Print();
var service3 = dependencyResolver.GetService<ConsumerService>();
service3.Print();
