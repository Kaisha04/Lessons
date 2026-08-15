using System.Collections;

namespace task2;

public class MyListEnum<T> : IEnumerator<T>
{
    private MyList<T> _list;
    private int _index;

    public MyListEnum(MyList<T> list)
    {
        _list = list;
        _index = -1;
    }

    public T Current => _list[_index];

    object IEnumerator.Current => Current;

    public bool MoveNext()
    {
        if (_index < _list.Count - 1)
        {
            _index++;
            return true;
        }
        return false;
    }

    public void Reset()
    {
        _index = -1;
    }

    public void Dispose()
    {
        // No resources to dispose
    }
}