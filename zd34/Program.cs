Console.Clear();

void Array(int[] collection)
{
    int length = collection.Length;
    int index=0;
    while (index < length)
{
    collection[index] = new Random().Next(100,1000);
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
        Console.WriteLine(col[position]);
        position++;

    }
}


void EvenArray(int[] arr)
    {
    int length = arr.Length;
    int index=0;
    int count=0;
    while (index < length)
{
    if (arr[index] % 2==0)
        count++;
        index++;
}
        Console.WriteLine("Количество чётных чисел в массиве " +count);
}




 int[] array = new int[8];

Array(array);
PrintArray(array);
EvenArray(array);