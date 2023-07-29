namespace Basic_examples_console;

public class GenericExample<T>
{
    private T[] _items;

    public GenericExample()
    {
        _items = new T[10];
    }
    
    // reset object to the default value (for int it is 0, for most other it is null etc..)
    public T makeDefault(T Item)
    {
        Item = default;
        return Item;
    }
}