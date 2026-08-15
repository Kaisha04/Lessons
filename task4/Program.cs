using System;
using task2;
namespace task4;

class Program
{
    static void Main()
    {
        MyList<int> myList = new MyList<int>();
        myList.Add(1);
        myList.Add(2);
        myList.Add(3);
        myList.Add(4);

        Console.WriteLine("\nUsing GetArray extension method:");
       var array = myList.GetArray();

       foreach (var item in array)
       {
           Console.WriteLine(item);
       }
    }
}