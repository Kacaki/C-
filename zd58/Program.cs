Console.Clear();



 int[,] CompArray(int[,] m1, int[,] m2, int[,] r)
    {
                         
            for (int i = 0; i < m1.GetLength(0); i++)
            {
                for (int j = 0; j < m2.GetLength(1); j++)
                {
                    for (int k = 0; k < m2.GetLength(0); k++)
                    {
                        r[i,j] += m1[i,k] * m2[k,j];
                    }
                }
            }
             return r;
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





int[,] m1 = new int[2,2];
int[,] m2 = new int[2,2];
int[,] r = new int[2,2];

FillArray(m1);
FillArray(m2);
Console.WriteLine();
Console.WriteLine("Зададим случайным образом матрицу №1");

PrintArray(m1);
Console.WriteLine("Зададим случайным образом матрицу №2");
PrintArray(m2);
CompArray(m1,m2,r);
Console.WriteLine("Произведем перемножение матриц и выведем результат на экран");
PrintArray(r);