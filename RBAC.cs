using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class RoleAllowedAttribute : Attribute
{
    public string Role { get; }

    public RoleAllowedAttribute(string role)
    {
        Role = role;
    }
}

class UserSession
{
    public static string CurrentUserRole { get; set; } = "USER";
}

class SecureOperations
{
    [RoleAllowed("ADMIN")]
    public void AdminTask()
    {
        Console.WriteLine("Admin task executed successfully.");
    }

    [RoleAllowed("USER")]
    public void UserTask()
    {
        Console.WriteLine("User task executed successfully.");
    }
}

class Program
{
    static void ExecuteIfAuthorized(object obj, string methodName)
    {
        MethodInfo method = obj.GetType().GetMethod(methodName);

        if (method == null)
        {
            Console.WriteLine($"Method {methodName} not found.");
            return;
        }

        var attribute = (RoleAllowedAttribute)Attribute.GetCustomAttribute(method, typeof(RoleAllowedAttribute));

        if (attribute != null)
        {
            if (UserSession.CurrentUserRole == attribute.Role)
            {
                method.Invoke(obj, null);
            }
            else
            {
                Console.WriteLine($"Access Denied! {UserSession.CurrentUserRole} cannot execute {methodName}.");
            }
        }
        else
        {
            method.Invoke(obj, null);
        }
    }

    static void Main()
    {
        SecureOperations operations = new SecureOperations();

        Console.WriteLine("Trying as USER:");
        ExecuteIfAuthorized(operations, "AdminTask");

        Console.WriteLine("\nSwitching to ADMIN role...");
        UserSession.CurrentUserRole = "ADMIN";
        ExecuteIfAuthorized(operations, "AdminTask");

        Console.WriteLine("\nTrying USER Task:");
        UserSession.CurrentUserRole = "USER";
        ExecuteIfAuthorized(operations, "UserTask");
    }
}
