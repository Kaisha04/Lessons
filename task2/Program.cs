using task2;

MyList<int> myList = new MyList<int>();
myList.Add(1);
myList.Add(2);
myList.Add(3);
myList.Add(4);
myList.Add(5);
myList.Add(6);

foreach (var item in myList)
{
    Console.WriteLine(item);
}

System.Console.WriteLine(myList[2]);     // Output: 3
System.Console.WriteLine(myList.Count); // Output: 6
System.Console.WriteLine(myList is IEnumerable<int>); // Output: True

