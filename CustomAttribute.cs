using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method, Inherited = false)]
class TaskInfoAttribute : Attribute
{
    public int Priority { get; }
    public string AssignedTo { get; }

    public TaskInfoAttribute(int priority, string assignedTo)
    {
        Priority = priority;
        AssignedTo = assignedTo;
    }
}

class TaskManager
{
    [TaskInfo(1, "John Doe")]
    public void CompleteTask()
    {
        Console.WriteLine("Task is being completed.");
    }
}

class Program
{
    static void Main()
    {
        Type type = typeof(TaskManager);
        MethodInfo method = type.GetMethod("CompleteTask");

        if (method != null)
        {
            object[] attributes = method.GetCustomAttributes(typeof(TaskInfoAttribute), false);
            foreach (TaskInfoAttribute attr in attributes)
            {
                Console.WriteLine($"Priority: {attr.Priority}, Assigned To: {attr.AssignedTo}");
            }
        }
    }
}
