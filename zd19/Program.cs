Console.Clear();

int entering()
  {
    Console.WriteLine("Введите пятизначное число");
    int a = int.Parse(Console.ReadLine());
    
    int lenght = a.ToString().Length;
    if (lenght != 5)
    Console.WriteLine("Вы ввели не 5 чисел");
    return a;

   }


int a = entering();
palindrom(a); 

void palindrom(int a)
    {
    string str = a.ToString();
    if (str[0] == str[4] && str[1] == str[3] )
        Console.WriteLine("Это число является палиндромом");
        
        else 
        Console.Write("Это число не является палиндромом");

    }