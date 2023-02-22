

void Digt(int n)

{
    
    for (int i=1; i != n+1; i++)
     {   
         double d = Math.Pow(i, 3);
            Console.WriteLine("Куб " + d);
     }
}





void Main()
  {

    Console.WriteLine("Введите число N");
    int n = int.Parse(Console.ReadLine());

    Digt(n);

   }

Main();