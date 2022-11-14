Console.WriteLine("Введите количество строк");
int N;
while (!int.TryParse(Console.ReadLine()!, out N) || N<=0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine ("Неверный ввод");
    Console.ResetColor(); 
    Console.WriteLine("Введите количество строк");   
}

Console.WriteLine("Введите количество столбцов");
int M;
while (!int.TryParse(Console.ReadLine()!, out M) || N<=0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine ("Неверный ввод");
    Console.ResetColor(); 
    Console.WriteLine("Введите количество столбцов");   
}

int [,] matrix = new int [N, M];
var random = new Random();

void PrintArray(int[,] matr)
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++)
        {
            Console.ForegroundColor = (ConsoleColor)random.Next(1, 16);
            if (matr[i, j]==100) Console.Write($" {matr[i, j]} ");
            else if (matr[i, j]<100 && matr[i, j]>9 ) Console.Write($" {matr[i, j]}  ");
            else Console.Write($" {matr[i, j]}   ");
            Console.ResetColor(); 
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++)
        {
           matr[i, j] = new Random().Next(1, 101);
        }
        
    }
}

void MinAndMax (int[,] matr)
{
    int max = matr[0, 0];
    int min = matr[0, 0];

    int index_max_i = 0;
    int index_max_j = 0;

    int index_min_i = 0;
    int index_min_j = 0;
 
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++)
        {
           if (matr[i, j]>max)
           {
                max = matr[i, j];
                index_max_i = i;
                index_max_j = j;
           }
           if (matr[i, j]<min)
           {
                min = matr[i, j];
                index_min_i = i;
                index_min_j = j;
           }
           
        }
        
    }
    Console.WriteLine();
    Console.WriteLine ($"Максимальный элемент {max} c индексами [{index_max_i};{index_max_j}]");
    Console.WriteLine ($"Минимальный элемент {min} c индексами [{index_min_i};{index_min_j}]");
}

void ArMean (int[,] matr)
{
    int sum = 0;
 
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++)
        {
           sum = sum +  matr[i, j];
        }
        
    }
    
    var armean = (float)sum/matrix.Length;
    double armean2 = Math.Round(armean, 2, MidpointRounding.AwayFromZero);

    Console.WriteLine();
    Console.WriteLine ($"Среднее арифметическое: {armean2}");
}

Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);
MinAndMax(matrix);
ArMean(matrix);