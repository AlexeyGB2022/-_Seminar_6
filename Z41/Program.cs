Console.WriteLine("Введите размер массива");
int N;
while (!int.TryParse(Console.ReadLine()!, out N) || N<=0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine ("Неверный ввод");
    Console.ResetColor(); 
    Console.WriteLine("Введите размер массива");   
}

int i = 0;
float[] arr = new float[N];

while (i<N)
{
    Console.WriteLine ($"Введите {i+1} элемент массива");

    while (!float.TryParse(Console.ReadLine()!, out arr[i]))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine ("Неверный ввод");
        Console.ResetColor(); 
        Console.WriteLine($"Введите {i+1} элемент массива");   
    }

    i++;
}

void PrintArray(float[] arr)
{
    Console.WriteLine ("Массив");
    for (int i = 0; i < N; i++)
    {
        Console.Write($"{arr[i]}  ");
    }
    Console.WriteLine();
}

void PosNum(float[] arr)
{
    int count = 0;
    for (int i = 0; i < N; i++)
    {
        if (arr[i]>0) count++;
    }
    Console.WriteLine();
    Console.WriteLine ($"Количество чисел больше нуля: {count}");

}

Console.WriteLine();
PrintArray(arr);
PosNum(arr);