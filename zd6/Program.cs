Console.Clear();
Console.WriteLine("введите число ");
int a = Convert.ToInt32(Console.ReadLine());



    if (a<0) a=(a*-1);
        if (a % 2==1)
                {
                    Console.WriteLine("число нечетное");
                }
                    else
                {
                    Console.WriteLine("Число четное");
                }