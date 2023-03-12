Console.Clear();

int Sum(int m, int n)
{
    int result = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        result = m + Sum(m, n);
        return result;
    }
}



void PrintSum(int m, int n)
{
    Console.Write(Sum(m - 1, n));
}



Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

PrintSum(m, n);