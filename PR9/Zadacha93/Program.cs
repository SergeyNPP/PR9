int Akkerman(int N, int m)
{
    //m+1 n=0
    //A(n-1,1) n!=0, m=0; 
    //A(n-1,A(n,m-1)) n>0, m>0

    if (N == 0)
    {
        return m + 1;
    }
    else
    {
        if ((N != 0) && (m == 0))
        {
            return Akkerman(N-1,1);
        }
        else
        {
            return Akkerman(N - 1, Akkerman(N, m - 1));
        }
        
    }
}
Console.WriteLine(Akkerman(2, 3));