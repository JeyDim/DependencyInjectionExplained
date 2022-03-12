namespace Stage4_LifeTimes.DI;

internal class DependencyResolver
{
    private readonly DependencyContainer _container;
    public DependencyResolver(DependencyContainer container)
    {
        _container = container;
    }

    public T GetService<T>()
    {
        return (T)GetService(typeof(T));
    }

    private object GetService(Type type)
    {
        var dependency = _container.GetDependency(type);
        var constructorInfo = dependency.Type.GetConstructors().Single();
        var parameterInfos = constructorInfo.GetParameters().ToArray();

        if (parameterInfos.Length == 0)
            return CreateImplementation(dependency, Activator.CreateInstance);

        var parameterImplementations = new object[parameterInfos.Length];

        for (var i = 0; i < parameterInfos.Length; i++)
        {
            parameterImplementations[i] = GetService(parameterInfos[i].ParameterType);
        }

        return CreateImplementation(dependency, t => Activator.CreateInstance(t, parameterImplementations));
    }

    private object CreateImplementation(Dependency dependency, Func<Type, object> factory)
    {
        if (dependency.IsImplemented)
            return dependency.Implementation;

        var implementation = factory(dependency.Type);

        if (dependency.Lifetime == EDependencyLifetime.Singleton)
            dependency.AddImplementation(implementation);

        return implementation;
    }
}
