Сумма нечетных элементов массива

using System;

public class Answer
{
    public static int SumOddElements(int[] array)
    {
        int sum = 0;
        for (int i = 1; i < array.Length; i = i + 2)
        {
            sum += array[i];
        }
        return sum;
    }

    public static void PrintArray(int[] array)
    {
      for (int i = 0; i < array.Length; i++)
      {
        Console.Write(array[i]);
        if (i < array.Length - 1) // Проверяем, не последний ли элемент
        {
        Console.Write("\t"); // Добавляем табуляцию после всех элементов, кроме последнего
        }
      }
        Console.WriteLine();
    }


    public static void Main(string[] args)
    {
        int[] array;
        if (args.Length == 0)
        {
            // Если аргументы не переданы, используем массив по умолчанию
            array = new int[] { 12, 64, 28, 93, 35, 47, 6, 72, 58, 21 };
        }
        else
        {
            string[] argStrings = args[0].Split(", ");
            array = new int[argStrings.Length];
            for (int i = 0; i < argStrings.Length; i++)
            {
                if (int.TryParse(argStrings[i], out int number))
                {
                    array[i] = number;
                }
                else
                {
                    Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
                    return;
                }
            }
        }

        PrintArray(array);
        int sumOdd = SumOddElements(array);
        Console.WriteLine($"Сумма нечетных элементов: {sumOdd}");
    }
}



// // Введите свое решение ниже
//     int sum =0;
//       for (int i =0; i < array.Length; i++){
//         if (i % 2 != 0) {
//           sum += array[i];
//         }
//       }
//       return sum;

//     }

//     public static void PrintArray(int[] array)
//     {
//          // Введите свое решение ниже
// Console.WriteLine($"{String.Join("\t", array)}");

//     }
