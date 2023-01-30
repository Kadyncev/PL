using static System.Console;

Clear(); 

Write("Введите число M: ");
int m = Convert.ToInt32(ReadLine());

Write("Введите число N: ");
int n = Convert.ToInt32(ReadLine());

SumFromMToN(m, n);

void SumFromMToN(int m, int n)
{
    Write(SumMN(m - 1, n));
}

int SumMN(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + SumMN(m, n);
        return res;
    }
}