Console.Clear();
Console.WriteLine("Введите число");
int b = int.Parse(Console.ReadLine());


Console.WriteLine("Какую по порядку цифру введенного числа вывести?");
int a = int.Parse(Console.ReadLine());

digt(a, b);

void digt(int x, int y)
{
        int lenght = y.ToString().Length; 

        if (lenght >=x )
            {
            string str = y.ToString();
            Console.Write("Вы выбрали цифру {0}", str[x-1]);
            }
        else 
            Console.WriteLine("Такой цифры нет");

}