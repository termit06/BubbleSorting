using System;

class Program
{
    static void Main()
    {
        int[] digitals = new int[10]; // объявили массив на 10 ячеек

        Console.WriteLine("Введите 10 чисел для заполнения массива: ");

        for (int i = 0; i < 10; i++)
        {
            digitals[i] = int.Parse(Console.ReadLine()); // "читаем" элементы в массив
        }

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                if (digitals[j] > digitals[j + 1])
                {
                    int b = digitals[j]; // создали дополнительную переменную
                    digitals[j] = digitals[j + 1]; // меняем местами
                    digitals[j + 1] = b; // значения элементов
                }
            }
        }

        Console.Write("Массив в отсортированном виде: ");

        for (int i = 0; i < 10; i++)
        {
            Console.Write(digitals[i] + " "); // выводим элементы массива
        }

        Console.WriteLine();
        Console.ReadKey();
    }
}