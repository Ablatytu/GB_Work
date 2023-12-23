using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите элементы массива через запятую:");
        string input = Console.ReadLine();

        // Разбиваем введенную строку на массив строк
        string[] inputArray = input.Split(',');

        // Вызываем метод, который формирует новый массив из строк, длина которых <= 3 символам
        string[] resultArray = FilterStrings(inputArray);

        // Выводим результат
        Console.WriteLine("Результат:");
        Console.WriteLine(string.Join(", ", resultArray));
    }

    static string[] FilterStrings(string[] inputArray)
    {
        // Подсчитываем количество строк, удовлетворяющих условию (длина <= 3)
        int count = 0;
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        // Создаем новый массив нужной длины
        string[] resultArray = new string[count];

        // Заполняем новый массив подходящими строками
        int index = 0;
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                resultArray[index] = str;
                index++;
            }
        }

        return resultArray;
    }
}
