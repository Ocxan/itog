using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите элементы массива, разделяя их запятыми:");
        string input = Console.ReadLine();

        string[] inputArray = input.Split(',');

        string[] newArray = FilterArray(inputArray);

        Console.WriteLine("Новый массив:");
        foreach (string element in newArray)
        {
            Console.WriteLine(element);
        }
    }
}
