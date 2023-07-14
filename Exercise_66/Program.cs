// See https://aka.ms/new-console-template for more information


int SumOfNums (int n, int m)
{
    if(n!=m)
    {
        return Math.Min(n,m) + SumOfNums(Math.Min(n,m) + 1 , Math.Max(m,n));
    }
    return Math.Min(n,m);
}

int sum = SumOfNums(1,15);
Console.WriteLine(sum);











