Console.Clear();



void PrintArray(int[,,] matr)
    {
        
        
          for (int i=0; i<matr.GetLength(0); i++)
            {
                for (int j=0; j<matr.GetLength(1); j++)
                    {
                        Console.WriteLine();
                        for (int k=0; k<matr.GetLength(2); k++)
                            {
                            Console.Write($" {matr[i,j,k] }");
                             Console.Write($"({i}");
                             Console.Write(j);
                             Console.Write($"{k})");
                            }
                    }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

void FillArray(int[,,] matr)
    {
        int p = new Random().Next(0,10);
        
        for (int m=0; m<matr.GetLength(0); m++)
            {
                for (int n=0; n<matr.GetLength(1); n++)
                    {
                        for (int k=0; k<matr.GetLength(2); k++)
                        {
                           
                            matr[m,n,k] = p;
                            p += new Random().Next(10,14);;
                           
                        }
                    
                    }
                
        
            }

        
    }





int[,,] m1 = new int[2,2,2];

FillArray(m1);

Console.WriteLine();
Console.WriteLine("Заполниим массив не повторяющимися значениями");

PrintArray(m1);
