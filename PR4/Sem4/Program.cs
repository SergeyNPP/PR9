// //Лекция введение в программирование. Выделяем 4 основных метода


// ВозвращаемыйТипДанных ИмяМетода([ТипДанных1 ИмяАрумена1, ...])
// {
//         Телометода
//         return ЗначениеСоответствующееВозвращаемомуТипуДанных;
// }

// Метод1 ничего не принимает, ничего не возвращают Void


// void Metod1()
// {
//     Console.WriteLine("Автор ...");
// }
// Metod1();

// Метод2 Что-то принимает, ничего не возвращает Void


// void Metod2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Metod2("Текст");

// void Metod21(string msg, int count)
// {
//    int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;//Инкремент i--; Декримент
//     }
// }
// Metod21("Текст", 4);
// Или так
// Metod21(msg:"Текст21", count: 4);
// Или так
// Metod21( count: 4, msg:"Текст21  Новый"); ЭТО ИМЕННОЙ , кода обращаемся count или msg


// Метод3 ничего не принимает, что-то возвращают

// int Metod3()
// {
//     return DateTime.Now.Year;
// }
// int year = Metod3();
// Console.WriteLine(year);



// Метод4 что-то принимает,  что-то возвращают 


// string Metod4(int count, string TextF2) //char C символ  (си)
// {
//    int i = 0; 
//    string result = string.Empty;

//    while (i<count)
//    {
//     result = result + TextF2;
//     i++;
//    }
//    return result;
// }

// string res = Metod4(10, "Поезда");
// Console.WriteLine(res);

// Цикл for (int i = 0; i < length; i++)
// {
//     Console.WriteLine();
// }


// string Metod41(int count, string TextF2)
// {
//    string result = string.Empty;
//    for (int i = 0; i < count; i++)
//    {
//     result = result + TextF2;
//    }
//    return result;
// }

// string res = Metod41(10, "Z");
// Console.WriteLine(res);

//  Цикл for (int i = 0; i < 10; i++)
//  {
//     цикл for (int j = 0; j < 10; j++)
//     {
//         Console.WriteLine(i*j);
//     }
//     Console.WriteLine();
//  }

// Таблица умножения

//  for (int i = 2; i <= 10; i++)
//  {
//     for (int j = 1; j <=10; j++)
//     {
//         Console.WriteLine($"{i}x{j} = {i*j}");
//     }
//     Console.WriteLine();
//  }



//  for (int i = 2; i <= 10; i++)
//  {
//     for (int j = 1; j <=10; j++)
//     {
//         Console.WriteLine($"{i}x{j} = {i*j}");
//     }
//     Console.WriteLine();
//  }
// //               Работа с текстом
// string text =  "— Я думаю, — сказал князь, улыбаясь, — что, "
//                +"ежели бы вас послали вместо нашего милого "
//                +"Винценгероде, вы бы взяли приступом согласие "
//                +"прусского короля. Вы так красноречивы. Вы "
//                +"дадите мне чаю?";

// // string s = "qwert"
// //             01234
// // s[3]  r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty; // <---инициализация пустой строки вылядит так
    
//     int length = text.Length; //<-- Для получения ДЛИНЫ строки 
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result +$"{newValue}";
//         else result = result +$"{text[i]}";
//     }
    
//     return result; 
// }   

// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(text, 'к', 'K');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(text, 'с', 'Л');
// Console.WriteLine(newText);
// |
// |
// |
// |
// |
// |
// |
// |
// |
// |
//6 8 3 2 1 4 5 7

int[] arr = {6, 8, 3, 2, 1, 4, 5, 7, 4, 9};        // Обязательно фигурные скобки {}

void PrintArray(int[] array)                       //<--вывод данного массива на экран
{
    int count = array.Length;                      //Получение количества элементов 

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}



void SelestionSort(int[] array)                    //<-- Метод упорядочивания наших чисел (1)


{
    for (int i = 0; i < array.Length - 1; i++)     // ОБРАЩЕНИЕ К ДЛИННЕ МАССИВА array.Length (2). Т.к. (6) начали с i+1, то здесь отнимаем
    {
        int minPos = i;                            // Позиция(символ), к которому мы обращаемся и запоминаем позицию (3) Рабочего элемента с которым будем производить какие либо действия
        
        for (int j = i +1 ; j < array.Length; j++) // (6) начальная позиция от которой начинаются (то, что отсортированно начинается с i+1 позиции и до последнего элемента array.Length)
         {
            if (array[j] < array[minPos])          //ищем минимальный элемент            (5) <------------------------------------------|
            minPos = j;                            //Смотрим текущий, если он меньше того элемента, который предполагали , то сохраняем |                                                         |
         }                                         //                                                                                   |
        int temporary = array[i];                  // меняем значение minPos c позицией, которую мы нашли temporary (3)                 |
        array[i] = array[minPos];                  // в i-ую позицию мы должны положить элемент, который найден в процессе работы блока |(4)
        array[minPos] = temporary;                 // простой обмен местами
    }
}
PrintArray(arr); // напечатали
SelestionSort(arr); // отсортировани
PrintArray(arr); // напечатали отсортированный


//                                                      КРАТКО,ЧТО БЫЛО ВВЕРХУ. Если поменять < на > то будет в обратном порядке
// void SelectionSort(int[] array)
// {
//      for (int i = 0; i < array.Length - 1; i++)
//      {
//          int minPosition = i;
//          for (int j = i + 1; j < array.Length; j++)
//          {
//              if (array[j] < array[minPosition])
//              {
//                  minPosition = j;
//              }
//          }
//      int temporary = array[i];
//      array[i] = array[minPosition];
//      array[minPosition] = temporary;
//      }
// }

int DigitCounter(int num)
{
    int counter = 0;
    while (num > 0)
    {
        num /= 10;
        counter++;
    }
    return counter;
}
System.Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine ());

System.Console.WriteLine(DigitCounter(num));



