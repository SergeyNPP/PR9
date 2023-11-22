
int FindSum(int n, int m)
{
    if (m != n)
    {
        if (n > m)
        {
            return FindSum(n - 1,m) + n;
        }
        else
        {
            return FindSum(m - 1,n) + m;
        }
    }
  return +m;
}
Console.WriteLine(FindSum(15,1));
