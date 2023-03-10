Console.Clear();



void SortArray(int[,] sort)
    {
    
           
       for (int i = 0; i < sort.GetLength(0); i++)
        {
            for (int j = 0; j < sort.GetLength(1); j++)
                {
                    for (int k = 0; k < sort.GetLength(1) - 1; k++)
                        {
                            if (sort[i, k] < sort[i, k + 1])
                                    {
                                        int temp = sort[i, k + 1];
                                        sort[i, k + 1] = sort[i, k];
                                        sort[i, k] = temp;
                                    }
                        }
                }
        }
    }



void PrintArray(int[,] matr)
    {
        
        
          for (int i=0; i<matr.GetLength(0); i++)
            {
                for (int j=0; j<matr.GetLength(1); j++)
                    {
                    Console.Write($" {matr[i,j] } ");         
                    }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

void FillArray(int[,] matr)
    {
        for (int m=0; m<matr.GetLength(0); m++)
            {
                for (int n=0; n<matr.GetLength(1); n++)

                matr[m,n] = new Random().Next(1,10);

            }

        
    }




int m = new Random().Next(4,10);
int n = new Random().Next(4,10);
int[,] matrix = new int[m,n];

Console.WriteLine("Зададим случайный двумерный массив и наполним его случайными числами");

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
SortArray(matrix);
Console.WriteLine("Отсортируем массив по убыванию");
PrintArray(matrix);