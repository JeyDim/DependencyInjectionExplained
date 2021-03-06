namespace Stage4_LifeTimes.DI;

internal class DependencyContainer
{
    private readonly List<Dependency> _dependencies;
    public DependencyContainer()
    {
        _dependencies = new List<Dependency>();
    }

    public void AddSingleton<T>()
    {
        _dependencies.Add(new Dependency(typeof(T), EDependencyLifetime.Singleton));
    }

    public void AddSingleton<T, T2>()
    {
        _dependencies.Add(new Dependency(typeof(T), typeof(T2), EDependencyLifetime.Singleton));
    }

    public void AddTransient<T>()
    {
        _dependencies.Add(new Dependency(typeof(T), EDependencyLifetime.Transient));
    }

    public void AddTransient<T, T2>()
    {
        _dependencies.Add(new Dependency(typeof(T), typeof(T2), EDependencyLifetime.Transient));
    }

    public Dependency GetDependency(Type type) =>
        _dependencies.First(dependency => dependency.Type.Name == type.Name);
}
