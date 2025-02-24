using System;
using System.Reflection;
using System.Runtime.CompilerServices;

public interface IGreeting
{
    void SayHello(string name);
    string GetGreetingMessage(string name);
}

public class GreetingService : IGreeting
{
    public void SayHello(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }

    public string GetGreetingMessage(string name)
    {
        return $"Good day, {name}!";
    }
}

public class LoggingProxy<T> : DispatchProxy
{
    private T _instance;

    public static T Create(T instance)
    {
        T proxy = Create<T, LoggingProxy<T>>();
        ((LoggingProxy<T>)(object)proxy)._instance = instance;
        return proxy;
    }

    protected override object Invoke(MethodInfo targetMethod, object[] args)
    {
        Console.WriteLine($"[LOG] Method '{targetMethod.Name}' is being called with arguments: {string.Join(", ", args)}");

        object result = targetMethod.Invoke(_instance, args);

        if (targetMethod.ReturnType != typeof(void))
        {
            Console.WriteLine($"[LOG] Method '{targetMethod.Name}' returned: {result}");
        }

        return result;
    }
}

class Program
{
    static void Main()
    {

        IGreeting greetingProxy = LoggingProxy<IGreeting>.Create(new GreetingService());

        greetingProxy.SayHello("Alice");
        string message = greetingProxy.GetGreetingMessage("Bob");
        Console.WriteLine($"Received Message: {message}");
    }
}
