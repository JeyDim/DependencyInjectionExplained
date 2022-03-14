namespace Stage3_SimpleDI.DI;

internal class DependencyContainer
{
    private readonly Dictionary<Type, Type> _dependencies;
    public DependencyContainer()
    {
        _dependencies = new Dictionary<Type, Type>();
    }

    public void AddDependency<T>()
    {
        _dependencies.Add(typeof(T), typeof(T));
    }

    public void AddDependency<T, T2>()
    {
        _dependencies.Add(typeof(T), typeof(T2));
    }

    public Type GetDependency(Type type) =>
        _dependencies.First(dependency => dependency.Key.Name == type.Name).Value;
}
