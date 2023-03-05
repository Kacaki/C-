

void dist(int k1, int b1,
          int k2, int b2)
{
    int x = 0;
    int y = 0;
    
    x = -(b1 - b2) / (k1 - k2);
    y =  k1 * x + b1;
    
            
    Console.WriteLine($"Точка пересечения двух прямых: ({x};{y})");

    
}


void Main()
{
    Console.WriteLine("Введите координату k1");
    int k1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координату b1");
    int b1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координату k2");
    int k2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координату b2");
    int b2 = int.Parse(Console.ReadLine());
    
    
    dist(k1, b1, k2, b2);

   }




Main();