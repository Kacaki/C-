void FillArray(int[] collection)
{
    int length = collection.length;
    int index=0;
    while (index < lenght)
{
    collection[index] = new Random().Next(1, 10);

    index++;
}



}

void PrintArray(int[] col)
{
    int count = col.length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;

    }
}

int Index0f(int[] collection, int find)
{
    int count = collection.Lenght;
    int index = 0;
    int position = 0;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;


        }
        index++;
    }
    return position;
}



int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = Index0f(array, 4);
Console.WriteLine(pos);
