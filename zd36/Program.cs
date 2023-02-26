Console.Clear();

void Array(int[] collection)
{
    int length = collection.Length;
    int index=0;
    while (index < length)
{
    collection[index] = new Random().Next(-100,100);
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


void SumArray(int[] arr)
    {
    int length = arr.Length;
    int index=0;
    int sum=0;
    while (index < length)
{
    if (index % 2==1)
        sum = (sum +arr[index]);
        index++;
}
        Console.WriteLine("Сумма чисел на четных индексах массива " +sum);
}





 int[] array = new int[8];

Array(array);
PrintArray(array);
SumArray(array);