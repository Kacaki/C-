Console.Clear();



void FillArrSpiral(int[,] matr, int n)
{
    int i = 0, j = 0;
    int value = 1;
    for (int s = 0; s < n * n; s++)
    {
        int k = 0;
        do { matr[i, j++] = value++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) matr[i++, j] = value++;
        for (k = 0; k < n - 1; k++) matr[i, j--] = value++;
        for (k = 0; k < n - 1; k++) matr[i--, j] = value++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}




void PrintArray(int[,] matr)
    {
        
        
          for (int i=0; i<matr.GetLength(0); i++)
            {
                for (int j=0; j<matr.GetLength(1); j++)
                    {
                        if (matr[i, j] < 10)
                            {
                                Console.Write("0" + matr[i, j]);
                                Console.Write(" ");
                            }
                                else Console.Write(matr[i, j] + " ");         
                    }
            Console.WriteLine();
        }
        Console.WriteLine();
    }




int l = 4;
int[,] matrix = new int[l,l];



Console.WriteLine();

Console.WriteLine("Зададим пустой массив");
Console.WriteLine();
PrintArray(matrix);
FillArrSpiral(matrix,l);
Console.WriteLine("Заполним его по спирали и выведем на экран");
PrintArray(matrix);