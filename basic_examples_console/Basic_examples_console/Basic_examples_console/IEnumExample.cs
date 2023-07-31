using System.Collections;
using System.Security.Cryptography;

namespace Basic_examples_console;

public class IEnumExample<T> :IEnumerable<T>
{
    private T[] _items;
    private int Count = -1;

    public IEnumExample()
    {
        _items = new T[10];
    }

    public void Push(T item)
    {
        if (Count < 10)
        {
            _items[++Count] = item;
        }
        else
        {
            throw new InvalidDataException();
        }
    }

    public T Pop ()
    {
        if (Count > -1)
        {
            var tmpVar = _items[Count];
            _items[Count--] = default;
            return tmpVar;
        }

        throw new IndexOutOfRangeException();
    }

    public T Peek()
    {
        if (Count == 0)
        {
            throw new IndexOutOfRangeException();
        }

        return _items[Count];
    }
    
    public IEnumerator<T> GetEnumerator()
    {
        return new MYIEnumerator<T>(_items);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

public class MYIEnumerator<T> : IEnumerator<T>
{
    private int position = -1;
    private readonly T[] _array;

    public MYIEnumerator(T[] array)
    {
        _array = array;
    }
    public bool MoveNext()
    {
        return ++position > _array.Length;
    }

    public void Reset()
    {
        position = -1;
    }

    public T Current => _array[position];

    object IEnumerator.Current => Current;

    public void Dispose()
    {
    }
}