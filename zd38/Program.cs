Console.Clear();

void Array(float[] collection)
{
    int length = collection.Length;
    int index=0;
    while (index < length)
{
    collection[index] = new Random().Next(-100,100);
    index++;
}

}
void PrintArray(float[] col)
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


void DiffArray(float[] arr)
    {
    int length = arr.Length;
    int index=0;
    float maxcount=-100;
    float mincount=0;
    float sum=0;
    while (index < length)
{
    if (arr[index] > maxcount)
        maxcount = arr[index];
    if (arr[index] < mincount)
        mincount = arr[index];
        index++;
}
        Console.WriteLine("максимальный элемент в массиве " + maxcount);
        Console.WriteLine("минимальный элемент в массиве" + mincount);
        
        
            sum = maxcount-mincount;
               
        Console.WriteLine("Разница масимального и минимального элемента массива равна " + sum);
}



 float[] array = new float[8];

Array(array);
PrintArray(array);
DiffArray(array);