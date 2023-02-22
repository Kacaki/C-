
Console.Clear();

void dist(int x1, int y1,
                     int z1, int x2,
                     int y2, int z2)
{
    double d = Math.Pow((Math.Pow(x2 - x1, 2) +
                         Math.Pow(y2 - y1, 2) +
                         Math.Pow(z2 - z1, 2) *
                                   1.0), 0.5);
    Console.WriteLine("Дистанция между 1ой и 2ой точкой = " + d);
    return;
}




void Main()
  {
    Console.WriteLine("Введите координату 1ой точки по оси x");
    int x1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координату 1ой точки по оси y");
    int y1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координату 1ой точки по оси z");
    int z1 = int.Parse(Console.ReadLine());
    
    Console.WriteLine("Введите координату 2ой точки по оси x");
    int x2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координату 2ой точки по оси y");
    int y2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координату 2ой точки по оси z");
    int z2 = int.Parse(Console.ReadLine());
    
    dist(x1, y1, z1,
             x2, y2, z2);

   }


Main();


