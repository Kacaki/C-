Console.Clear();



void SumArray(int[,] matr)
    {
    
           
        for (int i=0; i<matr.GetLength(1); i++)
            {
                double sum = 0;
                double razn = 0;
                for (int j=0; j<matr.GetLength(0); j++)
                    {
                    sum += matr[j, i];
                     
                    }
                    razn= Math.Round(sum/matr.GetLength(0), 2);
                    Console.WriteLine($"Среднее арифметическое столбца № {i+1} равно {razn}");  
                    
            }
    }






void PrintArray(int[,] matr)
    {
        
        Console.WriteLine("Зададим случайный двумерный массив и наполним его случайными числами");
        Console.WriteLine();
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




int m = new Random().Next(2,10);
int n = new Random().Next(2,10);
int[,] matrix = new int[m,n];


FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
SumArray(matrix);
