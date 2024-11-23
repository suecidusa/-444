using System;
using System;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите дату в формате ГГГГ-ММ-ДД: ");
        string input = Console.ReadLine();

        try
        {
            // Попытка преобразовать строку в дату
            DateTime date = DateTime.Parse(input);
            Console.WriteLine($"Вы ввели корректную дату: {date.ToShortDateString()}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: Введённая строка не соответствует формату даты.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла непредвиденная ошибка: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Завершение программы.");
        }
    }
}