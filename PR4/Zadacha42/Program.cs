// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12



// Console.WriteLine("Введи число");
// int N = Convert.ToInt32(Console.ReadLine());
// int res = 0;
//     while (N>0)
//     {
//         res += N % 10;
//         N = N / 10;
//     }
// Console.WriteLine(res);


int PR (string mes)
{
    System.Console.WriteLine(mes); 
   // string RI = System.Console.ReadLine();     Альтернатива
   //int res = int.Parse(RI);                       |
  int res = Convert.ToInt32(Console.ReadLine());//<-|
    return res;
}

int SM(int N)
{
    int res = 0;
    while(N>0)
    {
        res += N % 10;
        N = N / 10;
    }
    return res;
}

int N = PR("Chislo");
System.Console.WriteLine($"Sm {N} = {SM(N)}");