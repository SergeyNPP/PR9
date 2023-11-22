// void ShowNumber(int n)
// {
//     if (n>0)
//     {
//         ShowNumber(n-1);
//         Console.WriteLine(n + " ");
//     }
// }
// ShowNumber(6);


int FindSum(int num)
{
    if(num>0)
    {
        return FindSum(num/10) + num % 10;
    }
    return num;
}
Console.WriteLine(FindSum(453));


void FindSum(int n, int m)
{
    if (m != n)
    {
        if (n > m)
        {
            FindSum(n - 1,m);
            Console.Write(n + " ");
        }
        else
        {
            FindSum(m - 1,n);
            Console.Write(m + " ");
        }
    }
   else Console.Write(m + " ");
}
FindSum(8,4);