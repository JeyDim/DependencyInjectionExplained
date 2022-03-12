namespace Stage4_LifeTimes.DI;

internal class Dependency
{
    public Dependency(Type type, EDependencyLifetime lifetime)
    {
        Type = type;
        Lifetime = lifetime;
    }

    public Type Type { get; set; }
    public EDependencyLifetime Lifetime { get; set; }
    public object Implementation { get; set; }
    public bool IsImplemented { get; set; }

    public void AddImplementation(object implementation)
    {
        Implementation = implementation;
        IsImplemented = true;
    }
}
