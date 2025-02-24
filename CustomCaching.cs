using System;
using System.Collections.Generic;
using System.Reflection;

// Step 1: Define the CacheResult attribute
[AttributeUsage(AttributeTargets.Method)]
class CacheResultAttribute : Attribute { }

// Step 2: Implement a caching system using a Dictionary
class MethodCache
{
    private static Dictionary<string, object> cache = new Dictionary<string, object>();

    public static object ExecuteWithCaching(object obj, string methodName, params object[] args)
    {
        MethodInfo method = obj.GetType().GetMethod(methodName);

        if (method == null)
        {
            Console.WriteLine($"Method {methodName} not found.");
            return null;
        }

        var attribute = (CacheResultAttribute)Attribute.GetCustomAttribute(method, typeof(CacheResultAttribute));

        if (attribute != null)
        {
            // Generate a unique cache key using method name and parameters
            string cacheKey = methodName + "(" + string.Join(",", args) + ")";

            if (cache.ContainsKey(cacheKey))
            {
                Console.WriteLine($"Returning cached result for {methodName}({string.Join(", ", args)})");
                return cache[cacheKey];
            }

            // Execute and cache the result
            object result = method.Invoke(obj, args);
            cache[cacheKey] = result;
            Console.WriteLine($"Caching result for {methodName}({string.Join(", ", args)})");

            return result;
        }
        else
        {
            return method.Invoke(obj, args); // Execute normally if not cached
        }
    }
}

// Step 3: Apply CacheResult to a computationally expensive method
class ExpensiveOperations
{
    [CacheResult]
    public int ComputeFactorial(int n)
    {
        Console.WriteLine($"Computing factorial of {n}...");
        if (n == 0) return 1;
        return n * ComputeFactorial(n - 1);
    }
}

// Step 4: Test caching system
class Program
{
    static void Main()
    {
        ExpensiveOperations operations = new ExpensiveOperations();

        // First call (computes and caches the result)
        object result1 = MethodCache.ExecuteWithCaching(operations, "ComputeFactorial", 5);
        Console.WriteLine($"Factorial(5) = {result1}\n");

        // Second call with the same input (retrieves from cache)
        object result2 = MethodCache.ExecuteWithCaching(operations, "ComputeFactorial", 5);
        Console.WriteLine($"Factorial(5) = {result2}\n");

        // Different input (computes and caches again)
        object result3 = MethodCache.ExecuteWithCaching(operations, "ComputeFactorial", 6);
        Console.WriteLine($"Factorial(6) = {result3}");
    }
}
