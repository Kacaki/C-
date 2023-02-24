
Console.Clear();



    void Digt(int n)
        {
            int s = 0;
            while(n!=0)
            {
                s = s + n % 10;
                n = n / 10;
            }
            Console.WriteLine("Сумма чисел равна: {0}",s);
        }



 void Main()
  {

    Console.WriteLine("Введите число");
    int n = int.Parse(Console.ReadLine());
    
    Digt(n);

   }

Main();           