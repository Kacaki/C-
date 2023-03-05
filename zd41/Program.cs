

void FillArray(int[] coll)
{
    Console.Write("Введите элементы через пробел: ");
    int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int count = 0;
 
        for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                    {
                         count++;
                    }
            }
 
                Console.WriteLine($"Кол-во элементов более ноля: {count}");

}


int[] coll = new int[1];
FillArray(coll);