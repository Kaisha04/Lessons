using System.Collections;

namespace task2;

public class MyList<T> : IEnumerable<T>
{
    private T[] _items;
    private int _count;

    public MyList()
    {
        _items = new T[4];
        _count = 0;
    }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= _count)
            {
                throw new IndexOutOfRangeException();
            }
            return _items[index];
        }
    }


    public void Add(T item)
    {
        if (_count == _items.Length)
        {
            Resize();
        }
        _items[_count++] = item;
    }
    public int Count => _count;

    private void Resize()
    {
        T[] newItems = new T[_items.Length * 2];
        Array.Copy(_items, newItems, _items.Length);
        _items = newItems;
    }

    public IEnumerator<T> GetEnumerator()
    {
        return new MyListEnum<T>(this);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}