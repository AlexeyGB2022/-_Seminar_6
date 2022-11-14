Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Прямые, заданны уравнениями y = k1 * x + b1, y = k2 * x + b2");
Console.ResetColor(); 
Console.WriteLine();

Console.WriteLine("Введите k1, b1, k2, b2");

int N = 4;

int i = 0;
float[] arr = new float[N];

while (i<N)
{
    Console.WriteLine ($"Введити переменную");

    while (!float.TryParse(Console.ReadLine()!, out arr[i]))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine ("Неверный ввод");
        Console.ResetColor(); 
        Console.WriteLine($"Введите переменную");   
    }

    i++;
}

void Intersection(float[] arr)
{
    float x = (arr[1] - arr[3])/(arr[0] - arr[2])*(-1);
    float y = (arr[2]*x) + arr[3];
    Console.WriteLine();
    Console.WriteLine("Точа пересечения имеет координаты: ");
    Console.WriteLine($"x = {x}; y = {y}");
}

Intersection(arr);
