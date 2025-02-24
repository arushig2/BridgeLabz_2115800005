using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

[AttributeUsage(AttributeTargets.Constructor)]
public class InjectAttribute : Attribute { }
public class DIContainer
{
    private Dictionary<Type, Type> _typeMappings = new Dictionary<Type, Type>();

    public void Register<TInterface, TImplementation>() where TImplementation : TInterface
    {
        _typeMappings[typeof(TInterface)] = typeof(TImplementation);
    }

    public T Resolve<T>()
    {
        return (T)Resolve(typeof(T));
    }

    private object Resolve(Type type)
    {
        if (!_typeMappings.ContainsKey(type) && !type.IsClass)
        {
            throw new InvalidOperationException($"Type {type.Name} not registered.");
        }

        Type implementationType = _typeMappings.ContainsKey(type) ? _typeMappings[type] : type;

        ConstructorInfo constructor = implementationType.GetConstructors()
            .FirstOrDefault(c => c.GetCustomAttribute<InjectAttribute>() != null) ??
            implementationType.GetConstructors().FirstOrDefault();

        if (constructor == null)
        {
            throw new InvalidOperationException($"No suitable constructor found for {implementationType.Name}.");
        }

        ParameterInfo[] parameters = constructor.GetParameters();
        object[] paramInstances = parameters.Select(p => Resolve(p.ParameterType)).ToArray();

        return constructor.Invoke(paramInstances);
    }
}
public interface ILogger
{
    void Log(string message);
}

public class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"[LOG]: {message}");
    }
}

public class Service
{
    private readonly ILogger _logger;

    [Inject]
    public Service(ILogger logger)
    {
        _logger = logger;
    }

    public void DoWork()
    {
        _logger.Log("Service is doing work...");
    }
}

class Program
{
    static void Main()
    {

        DIContainer container = new DIContainer();
        container.Register<ILogger, ConsoleLogger>();

        Service service = container.Resolve<Service>();
        service.DoWork();
    }
}
