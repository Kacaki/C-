Console.Clear();
Console.WriteLine("введите число ");
int a = Convert.ToInt32(Console.ReadLine());


if (a>0)
    for (int b = 1;b<=a; b++)
        
        if (b % 2==0)
            Console.WriteLine(b);
        
if (a<0) 
    for (int b = -1;b>=a; b=b-1)
        
        if (b % 2==0)
            Console.WriteLine(b);
