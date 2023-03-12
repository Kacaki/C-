Console.Clear();



//  int[,] CompArray(int[,] m1, int[,] m2, int[,] r)
//     {
                         
//             for (int i = 0; i < m1.GetLength(0); i++)
//             {
//                 for (int j = 0; j < m2.GetLength(1); j++)
//                 {
//                     for (int k = 0; k < m2.GetLength(0); k++)
//                     {
//                         r[i,j] += m1[i,k] * m2[k,j];
//                     }
//                 }
//             }
//              return r;
//         }






void PrintArray(int[,,] matr)
    {
        
        
          for (int i=0; i<matr.GetLength(0); i++)
            {
                for (int j=0; j<matr.GetLength(1); j++)
                    {
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
        int[] p = new int[8];
        

        for (int m=0; m<matr.GetLength(0); m++)
            {
                for (int n=0; n<matr.GetLength(1); n++)
                    {
                        for (int k=0; k<matr.GetLength(2); k++)
                        {
                           
                            matr[m,n,k] = new Random().Next(1,99);
                           
                        }
                    
                    }
                
        
            }

        
    }





int[,,] m1 = new int[2,2,2];

FillArray(m1);

Console.WriteLine();
Console.WriteLine("Зададим случайным образом трехмерный массив");

PrintArray(m1);
