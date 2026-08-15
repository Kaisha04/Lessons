using System;
using task2;
using System.Collections.Generic;

namespace task4;


public static class Extension
{
    public static T[] GetArray<T>(this IEnumerable<T> MyListEnum)
    {
        List<T> list = new List<T>();
        foreach (var item in MyListEnum)
        {
            list.Add(item);
            
        }
        return list.ToArray();
    }
}