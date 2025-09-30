namespace QueueList;

public class QueueUsingList<T>
{
    private List<T> _elements;

    public QueueUsingList()
    {
        _elements = [];
    }

    public void Enqueue(T item)
    {
        _elements.Add(item);
    }

    public T Dequeue()
    {
        if (_elements.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty");
        }
        var item = _elements[0];
        _elements.RemoveAt(0);
        return item;
    }

    public T Peek()
    {
        if (_elements.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty");
        }
        return _elements[0];
    }
}