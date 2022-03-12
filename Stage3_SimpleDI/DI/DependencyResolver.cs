namespace Stage3_SimpleDI.DI;

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
        var constructorInfo = dependency.GetConstructors().Single();
        var parameterInfos = constructorInfo.GetParameters().ToArray();

        if (parameterInfos.Length == 0)
            return Activator.CreateInstance(dependency);

        var parameterImplementations = new object[parameterInfos.Length];

        for (var i = 0; i < parameterInfos.Length; i++)
        {
            parameterImplementations[i] = GetService(parameterInfos[i].ParameterType);
        }

        return Activator.CreateInstance(dependency, parameterImplementations);
    }
}
