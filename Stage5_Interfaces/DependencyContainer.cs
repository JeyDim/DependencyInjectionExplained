namespace Stage5_Interfaces;

internal class DependencyContainer
{
    private Dictionary<Type, Type> _dependencies;

    public DependencyContainer()
    {
        _dependencies = new Dictionary<Type, Type>();
    }

    public void AddDependency<T>()
    {
        var type = typeof(T);
        if (type.IsClass is false)
            throw new ArgumentException($"Type {nameof(T)} is not class", nameof(T));

        _dependencies.Add(type, type);
    }

    public void AddDependency<T, T2>()
    {
        _dependencies.Add(typeof(T), typeof(T2));
    }

    public Type GetDependency(Type type) =>
        _dependencies.First(keyValuePair => keyValuePair.Key.Name == type.Name).Value;
}
