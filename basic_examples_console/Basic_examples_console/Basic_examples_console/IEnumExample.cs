using System.Collections;
using System.Security.Cryptography;

namespace Basic_examples_console;

public class IEnumExample<T> :IEnumerable<T>
{
    private T[] _items;
    private int Count; // 0 by default
    private int _itemsLength;

    public IEnumExample(int itemsLength = 10)
    {
        _itemsLength = itemsLength;
        _items = new T[_itemsLength];
    }

    public void Push(T item)
    {
        if (Count < _itemsLength)
        {
            _items[Count++] = item; // because of the operations order, first we store item in the _items[Count] and then increasing Count by 1, performing Count++; increase Count BEFORE - use ++Count instead.
        }
        else
        {
            throw new InvalidDataException();
        }
    }

    public T Pop ()
    {
        if (Count >= 0)
        {
            var tmpVar = _items[Count - 1];
            _items[--Count] = default;
            
            return tmpVar;
        }

        throw new IndexOutOfRangeException();
    }

    public T Peek()
    {
        if (Count < 0)
        {
            throw new IndexOutOfRangeException();
        }
        return _items[Count - 1];
    }
    
    public IEnumerator<T> GetEnumerator()
    {
        return new MYIEnumerator<T>(_items, Count);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

public class MYIEnumerator<T> : IEnumerator<T>
{
    private int position;
    private int Count;
    private readonly T[] _array;

    public MYIEnumerator(T[] array, int Count)
    {
        _array = array;
        this.Count = Count;
        position = Count;
    }
    public bool MoveNext()
    {
        position--;
        return position >= 0;
    }

    public void Reset()
    {
        position = Count;
    }

    public T Current => _array[position];

    object IEnumerator.Current => Current;

    public void Dispose()
    {
    }
}