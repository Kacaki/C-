
Console.Clear();

void Array(int[] collection)
{
    int length = collection.Length;
    int index=0;
    while (index < length)
{
    collection[index] = new Random().Next(1,8);
    index++;
}

}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    Console.WriteLine("Выводим случайно заданный массив из 8 чисел");
    while (position < count)
    {
        Console.Write(col[position]);
        position++;

    }
}

 int[] array = new int[8];

Array(array);
PrintArray(array);