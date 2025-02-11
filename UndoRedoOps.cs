using System;

public class TextState
{
    public string content;
    public TextState prev;
    public TextState next;

    public TextState(string content)
    {
        this.content = content;
        prev = null;
        next = null;
    }
}

public class TextEditor
{
    private TextState currentState;
    private int historyLimit = 10;
    private int stateCount = 0;

    public TextEditor()
    {
        currentState = new TextState(""); // Initial empty state
    }

    // Add a new text state (record action)
    public void AddState(string newText)
    {
        TextState newState = new TextState(newText);

        if (currentState != null)
        {
            newState.prev = currentState;
            currentState.next = newState;
        }

        currentState = newState;
        stateCount++;

        // Limit history size
        if (stateCount > historyLimit)
        {
            RemoveOldestState();
        }
    }

    // Undo operation (move to the previous state)
    public void Undo()
    {
        if (currentState.prev != null)
        {
            currentState = currentState.prev;
            Console.WriteLine("Undo performed.");
        }
        else
        {
            Console.WriteLine("No more undo actions available.");
        }
    }

    // Redo operation (move to the next state)
    public void Redo()
    {
        if (currentState.next != null)
        {
            currentState = currentState.next;
            Console.WriteLine("Redo performed.");
        }
        else
        {
            Console.WriteLine("No more redo actions available.");
        }
    }

    // Display the current state of the text
    public void Display()
    {
        Console.WriteLine($"Current Text: \"{currentState.content}\"");
    }

    // Remove the oldest state to maintain history limit
    private void RemoveOldestState()
    {
        TextState temp = currentState;

        // Move back to the oldest state
        while (temp.prev != null)
        {
            temp = temp.prev;
        }

        // Remove the oldest state
        if (temp.next != null)
        {
            temp.next.prev = null;
        }
        stateCount--;
    }
}

class Program
{
    static void Main(string[] args)
    {
        TextEditor editor = new TextEditor();

        // Simulating typing actions
        editor.AddState("Hello");
        editor.AddState("Hello, World!");
        editor.AddState("Hello, World! This is a test.");
        editor.AddState("Hello, World! This is a C# text editor.");

        // Display current text
        editor.Display();

        // Performing undo operations
        editor.Undo();
        editor.Display();

        editor.Undo();
        editor.Display();

        // Performing redo operation
        editor.Redo();
        editor.Display();

        // Adding more states to exceed the history limit
        for (int i = 1; i <= 12; i++)
        {
            editor.AddState($"State {i}");
        }

        // Checking the limited history
        editor.Display();
    }
}
