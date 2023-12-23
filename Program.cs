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
}
