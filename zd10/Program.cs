Console.Clear();
Console.WriteLine("Введите число");
int b = int.Parse(Console.ReadLine());


Console.WriteLine("Какую по порядку цифру введенного числа вывести?");
int a = int.Parse(Console.ReadLine());

int lenght = b.ToString().Length; 

if (lenght >=a )
    {
    string str = b.ToString();
    Console.WriteLine(str[a-1]);
    }
   else 
    Console.WriteLine("Такой цифры нет");
