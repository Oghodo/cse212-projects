public class PriorityQueue
{
    private List<PriorityItem> _queue = new();

    /// <summary>
    /// Add a new value to the queue with an associated priority.  The
    /// node is always added to the back of the queue regardless of 
    /// the priority.
    /// </summary>
    /// <param name="value">The value</param>
    /// <param name="priority">The priority</param>
    public void Enqueue(string value, int priority)
    {
        var newNode = new PriorityItem(value, priority);
        _queue.Add(newNode);
    }

    public string Dequeue()
    {
        if (_queue.Count == 0) // Verify the queue is not empty
        {
            throw new InvalidOperationException("The queue is empty.");
        }

        // Find the index of the item with the highest priority to remove
        var highPriorityIndex = 0;
        for (int index = 1; index < _queue.Count - 1; index++)
        {
            if (_queue[index].Priority >= _queue[highPriorityIndex].Priority)
                highPriorityIndex = index;
        }

        // Remove and return the item with the highest priority
        var value = _queue[highPriorityIndex].Value;
        return value;
    }

    public override string ToString()
    {
        return $"[{string.Join(", ", _queue)}]";
    }
}

internal class PriorityItem
{
    internal string Value { get; set; }
    internal int Priority { get; set; }

    internal PriorityItem(string value, int priority)
    {
        Value = value;
        Priority = priority;
    }

    public override string ToString()
    {
        return $"{Value} (Pri:{Priority})";
    }
}
public class PriorityQueue
{
    private List<(string Value, int Priority)> _queue = new List<(string, int)>();

    public void Enqueue(string value, int priority)
    {
        _queue.Add((value, priority)); // Add to the end (FIFO)
    }

    public string Dequeue()
    {
        if (_queue.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty");
        }

        int maxPriority = int.MinValue;
        int indexOfMax = -1;

        // Find first occurrence of highest priority
        for (int i = 0; i < _queue.Count; i++)
        {
            if (_queue[i].Priority > maxPriority)
            {
                maxPriority = _queue[i].Priority;
                indexOfMax = i;
            }
        }

        string value = _queue[indexOfMax].Value;
        _queue.RemoveAt(indexOfMax); // Remove first highest-priority item
        return value;
    }
}
