Console.WriteLine("Введиет ваше имя");
string username = Console.ReadLine();

if (username.ToLower() == "алёна")
{
    Console.WriteLine("пупсик с Днем Валентина");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}