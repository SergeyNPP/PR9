// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());        
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

System.Console.WriteLine("Размер массива");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите элементы массива");
int[] myArr = CreateArray(size);
int count = 0;
 for (int i = 0; i < myArr.Length; i++)
 {
    if (myArr[i]>0)
    {
        count++;
    }
 }
 System.Console.WriteLine($"количество положительных элементов = {count}");

PrintArray(myArr);
