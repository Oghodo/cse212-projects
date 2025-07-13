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
