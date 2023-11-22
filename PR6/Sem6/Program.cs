// Урок 5. Функции и одномерные массивы

// Задача 31 Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму положительных и отрицательных  элеменов массива

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue +1 );        
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


// метод, считающий сумму + и - элементов массива

void FindPosNegSum (int[] array)
{
    int sumPos = 0;
    int sumNeg = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0) sumPos += array[i];
        else sumNeg += array[i];
    }
    System.Console.WriteLine($"Sum Positive -> {sumPos}, Sum Negative -> {sumNeg}");
}

System.Console.WriteLine("Размер массива");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("От");
int minValue = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("До");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] myArr = CreateRandomArray(size, minValue, maxValue);
System.Console.WriteLine();
FindPosNegSum(myArr);
PrintArray(myArr);
