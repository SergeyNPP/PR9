void ShowNumber(int n)
{
    if (n>0)
    {
        Console.WriteLine(n + " ");
        ShowNumber(n-1);
    }
}
ShowNumber(6);
