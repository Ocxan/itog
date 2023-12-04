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
            Console.WriteLine(element );
        }
    }
     static string[] FilterArray(string[] array)
    {
        int count = 0;

        // Подсчитываем количество строк, длина которых меньше или равна 3 символам
        foreach (string element in array)
        {
            if (element.Length <= 3)
            {
                count++;
            }
        }

        // Создаем новый массив необходимого размера
        string[] filteredArray = new string[count];

        // Заполняем новый массив строками, длина которых меньше или равна 3 символам
        int index = 0;
        foreach (string element in array)
        {
            if (element.Length <= 3)
            {
                filteredArray[index] = element;
                index++;
            }
        }

        return filteredArray;
    }
}
