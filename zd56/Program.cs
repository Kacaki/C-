Console.Clear();



void SumArray(int[,] matr)
    {
           int s1=0;
           int s2=0; 
           int mensh = 10000;
           
        for (int i=0; i<matr.GetLength(0); i++)
            {
                int sum = 0;
                
                for (int j=0; j<matr.GetLength(1); j++)
                    {
                    sum += matr[i, j];
                                        
                    }
                     Console.WriteLine($"Сумма строки № {i+1} равно {sum}");          
            
                    if (mensh > sum) 
                        {mensh = sum;  s1=i+1;}        
                    if (mensh == sum)
                            s2=i+1;

                        
            }
            Console.WriteLine();
            if (s1==s2) 
            Console.WriteLine($" Меньшая сумма строки равна {mensh} соотв-но это строка № {s1}");
            else 
            Console.WriteLine($" Меньшая сумма строки равна {mensh} соотв-но это строка № {s1} и № {s2}");
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




int m = new Random().Next(7,12);
int n = new Random().Next(3,5);
int[,] matrix = new int[m,n];


FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
SumArray(matrix);
