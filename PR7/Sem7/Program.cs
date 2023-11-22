using System.ComponentModel.DataAnnotations.Schema;
using System.Net.NetworkInformation;
using System.Numerics;

// Лекция 4 Рекурсия и Двумерные массивы
// тип данных   указание размерности(строки, столбцы)  имя массива     сколько строк(2) и столбцов(3)
// string               [,]                               table        = new string[2,3];

// string[,] table = new string[2,3];
// int[,] matrix = new int[5,8];

// string[,] table = new string[2,5];
// // для строк по умолачанию инициализация константой String.Empty
// //table[0,0]    table[0,1]  table[0,2]  table[0,3]  table[0,4]
// //table[1,0]    table[1,1]  table[1,2]  table[1,3]  table[1,4]

// table[1,2] = "1слово";
// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }

// }


// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i,j]} ");
//         }
//         System.Console.WriteLine();
//     }
// }

// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i,j] = new Random().Next(1,10);
//         }
//     }
// } 

// int[,] matrix = new int[3,4];
// // строки matrix.GetLength(0) и столбцы matrix.GetLength(1)
// PrintArray(matrix);
// FillArray(matrix);
// System.Console.WriteLine();
// PrintArray(matrix);



// // Рекурсия - Функция вызывает сама себя
// void FillImage(int row, int col)
// {
//     if(pic[row, col] ==0)
//     {
//         pic[row,col] = 1;
//         FillImage(row-1, col);
//         FillImage(row, col-1);
//         FillImage(row+1, col);
//         FillImage(row, col+1);
//     }
// }

// PrintArray(pic);
// FillImage(13,13);
// PrintArray(pic);

double Factorial(int n)
{
    if (n==1) return 1;
    else return n * Factorial(n-1); // Обязательно возвращать
}
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");   
}

int Fibonacci(int n)
{
    if(n==1 || n==2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

for (int i = 1; i < 20; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}