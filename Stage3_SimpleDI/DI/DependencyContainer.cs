namespace Stage3_SimpleDI.DI;

internal class DependencyContainer
{
    private List<Type> _dependencies;
    public DependencyContainer()
    {
        _dependencies = new List<Type>();
    }

    public void AddDependency<T>()
    {
        _dependencies.Add(typeof(T));
    }

    public Type GetDependency(Type type) =>
        _dependencies.First(dependency => dependency.Name == type.Name);
}
