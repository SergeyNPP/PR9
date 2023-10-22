// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

                        //Шутка

// Console.WriteLine("Введите 8 случайных чисел");

// int a1 = Convert.ToInt32(Console.ReadLine());
// int a2 = Convert.ToInt32(Console.ReadLine());
// int a3 = Convert.ToInt32(Console.ReadLine());
// int a4 = Convert.ToInt32(Console.ReadLine());
// int a5 = Convert.ToInt32(Console.ReadLine());
// int a6 = Convert.ToInt32(Console.ReadLine());
// int a7 = Convert.ToInt32(Console.ReadLine());
// int a8 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"[{a1}, {a2}, {a3}, {a4}, {a5}, {a6}, {a7}, {a8}]");



                    // Ввод чисел с консоли, вывод их в массив

void Prog()
{
Console.WriteLine("Введи количество элементов массива"); 
int Dlina = Convert.ToInt32(Console.ReadLine());
{
                                                                    //Пример
                                                                    //var numbers = new int[3];
                                                                    // numbers[0] = 10;
                                                                    // numbers[1] = 20;
                                                                    // numbers[2] = 30;

                                                                    // Console.WriteLine(string.Join(", ", numbers));
                                                                    // Output:
                                                                    // 10, 20, 30
    int[] Мarray = new int[Dlina];
    int[] ar = new int[Dlina];
    System.Console.WriteLine("Вводи элементы для массива");
int j = 0;
    for (int i = 0; i < Dlina; i++)
        {
            Мarray[i] =Convert.ToInt32(Console.ReadLine());
            ar[j]= Мarray[i];
            j++;

        }  
    j=0;
    Console.Write("[");
    for (int Lp = 0; Lp < Dlina-1; Lp++)
    
    {
        
       Console.Write($"{ar[j]}, ");  
       j++; 
    }
    Console.Write($"{ar[Dlina-1]}");
    Console.WriteLine("]");
}
}
Prog();



//                       // вводим числа с экрана
// int Pr(string mes)
// {
//     System.Console.WriteLine(mes);//выводим приглашение ко вводу
//     string ReadI = System.Console.ReadLine();
//     int res = int.Parse(ReadI);//приводим к числу
//     return res;//возвращаем результат
// }
// //            Метод для получения случайных значений массива
// int[] GenArr(int Length, int minVal, int maxVal)
// {
//     int[] arr = new int[Length];//объявляем массив
//     Random random = new Random();
//     for (int i = 0; i < Length; i++)
//     {
//         arr[i] = random.Next(minVal, maxVal + 1); //заполняем случайными числами из диапазона       
//     }
//     return arr;
// }
// void PrintArr(int[] array)
// {
//     System.Console.Write("[");
//     for (int i = 0; i < array.Length-1; i++)
//     {
//         System.Console.Write($"{array[i]}, "); //вывод значений массива
//     }
//     System.Console.Write($"{array[array.Length - 1]}");//вывод значения
//     System.Console.WriteLine("]");    
// }

// int length = Pr("Длина массива: ");
// int min = Pr("Начальнаое значение, для диапазона случайных чисел: ");
// int max = Pr("Конечное значение, для диапазона случайных чисел: ");
// int[] METODarray = GenArr(length, min, max); // заполнение массива случайными числами
// PrintArr(METODarray); //вывод массива






