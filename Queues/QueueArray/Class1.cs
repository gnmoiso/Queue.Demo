namespace QueueArray;

public class QueueUsingArray<T>
{
    private T[] _elements;
    private int _front;
    private int _rear;
    private int _count;
    private int _capacity;

    public QueueUsingArray(int capacity)
    {
        _elements = new T[capacity];
        _front = 0;
        _rear = -1;
        _count = 0;
    }

    public void Enqueue(T item)
    {
        if (_count == _elements.Length)
        {
            throw new InvalidOperationException("Queue is full");
        }
        _rear = (_rear + 1) % _elements.Length;
        _elements[_rear] = item;
        _count++;
    }

    public T Dequeue()
    {
        if (_count == 0)
        {
            throw new InvalidOperationException("Queue is empty");
        }
        var item = _elements[_front];
        _front = (_front + 1) % _elements.Length;
        _count--;
        return item;
    }

    public T Peek()
    {
        if (_count == 0)
        {
            throw new InvalidOperationException("Queue is empty");
        }
        return _elements[_front];

    }
}