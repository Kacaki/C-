Console.Clear();


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
    }


void FillArray(int[,] matr)
    {
        for (int i=0; i<matr.GetLength(0); i++)
            {
                for (int j=0; j<matr.GetLength(1); j++)

                matr[i,j] = new Random().Next(-10,10);

            }

        
    }


Console.WriteLine("Введите число строк");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int n = int.Parse(Console.ReadLine());

int[,] matrix = new int[m,n];


FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);