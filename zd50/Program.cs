Console.Clear();

void PrintArray(int[,] matr)
    {
    
        Console.WriteLine("Проверка");    
        for (int i=0; i<matr.GetLength(0); i++)
            {
                for (int j=0; j<matr.GetLength(1); j++)
                    {
                    Console.Write($" {matr[i,j] } ");         
                    }
            Console.WriteLine();
        }
    }



void SearchArray(int[,] matr)
    {
        Console.WriteLine("Введите номер строки индекса");
        int m = (int.Parse(Console.ReadLine())-1);
        Console.WriteLine("Введите номер столбца индекса");
        int n = (int.Parse(Console.ReadLine())-1);

        if (m < 0 | m > matr.GetLength(0)-1 | n < 0 | n > matr.GetLength(1)-1)
             Console.WriteLine("Элемент не существует");
            
        else
            Console.WriteLine("Значение элемента массива = {0}", matr[m, n]);
            

    }

void FillArray(int[,] matr)
    {
        for (int m=0; m<matr.GetLength(0); m++)
            {
                for (int n=0; n<matr.GetLength(1); n++)

                matr[m,n] = new Random().Next(-10,10);

            }

        
    }



int m = new Random().Next(1,10);
int n = new Random().Next(1,10);
int[,] matrix = new int[m,n];


FillArray(matrix);
Console.WriteLine();
SearchArray(matrix);
PrintArray(matrix);