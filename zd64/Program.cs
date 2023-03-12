


void Digt(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        Digt(n, count + 1);
        Console.Write(count + " ");
    }
}


Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;
Digt(n, count);
