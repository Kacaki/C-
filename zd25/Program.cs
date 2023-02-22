
Console.Clear();

void Digt(int n, int i)

{
    
        
         double d = Math.Pow(n, i);
            Console.WriteLine("Куб " + d);
     
}


void Main()
  {

    Console.WriteLine("Введите 1ое число");
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите 2ое число");
    int i = int.Parse(Console.ReadLine());
    
    Digt(n,i);

   }

Main();


