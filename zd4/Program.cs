Console.Clear();
Console.WriteLine("введите число 1 ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите число 2 ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите число 3 ");
int c = Convert.ToInt32(Console.ReadLine());


int max;

if (a>b) max=a;
if (a>c) max=a;
if (c>b) max=c;
else max=b;

Console.Write("Масимальное число равно ");
Console.Write(max);

