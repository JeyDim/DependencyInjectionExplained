namespace Stage4_LifeTimes.DI;

internal class Dependency
{
    public Dependency(Type type, EDependencyLifetime lifetime)
    {
        MappedType = Type = type;
        Lifetime = lifetime;
    }
    
    public Dependency(Type type, Type type2, EDependencyLifetime lifetime)
    {
        Type = type;
        MappedType = type2;
        Lifetime = lifetime;
    }

    public Type Type { get; set; }
    public Type MappedType { get; set; }
    public EDependencyLifetime Lifetime { get; set; }
    public object Implementation { get; set; }
    public bool IsImplemented { get; set; }

    public void AddImplementation(object implementation)
    {
        Implementation = implementation;
        IsImplemented = true;
    }
}
