// Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
//  Створіть колекцію MyDictionary. Реалізуйте у найпростішому наближенні можливість використання її екземпляра аналогічно екземпляру класу Dictionary.
//   Мінімально необхідний інтерфейс взаємодії з екземпляром повинен включати метод додавання елемента,
//    індексатор для отримання значення елемента за вказаним індексом і властивість тільки для читання для отримання загальної кількості елементів. 
// Реалізуйте можливість перебору елементів колекції у циклі наперед.
using System.IO;

namespace task3;

class Program
{
    static void Main()
    {
        MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();

        myDictionary.Add("One", 1);
        myDictionary.Add("Two", 2);
        myDictionary.Add("Three", 3);

        Console.WriteLine($"Count: {myDictionary.Count}");

        Console.WriteLine($"Value for 'Two': {myDictionary["Two"]}");

        Console.WriteLine("Iterating through the dictionary:");
        foreach (var item in myDictionary)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}