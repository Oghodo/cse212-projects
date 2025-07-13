public class TakingTurnsQueue
{
    private Queue<Person> _queue = new Queue<Person>();

    public void AddPerson(string name, int turns)
    {
        _queue.Enqueue(new Person(name, turns));
    }

    public string GetNextPerson()
    {
        if (_queue.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty");
        }

        Person person = _queue.Dequeue();

        if (person.Turns <= 0)
        {
            _queue.Enqueue(person);
        }
        else
        {
            person.Turns--;
            if (person.Turns > 0)
            {
                _queue.Enqueue(person);
            }
        }

        return person.Name;
    }
}

