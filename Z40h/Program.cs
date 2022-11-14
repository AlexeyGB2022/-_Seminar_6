int N = 3;

int i = 0;
float[] arr = new float[N];

while (i<N)
{
    Console.WriteLine ($"Введите {i+1} сторону треугольника");

    while (!float.TryParse(Console.ReadLine()!, out arr[i]) || arr[i]<=0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine ("Неверный ввод");
        Console.ResetColor(); 
        Console.WriteLine($"Введите {i+1} сторону треугольника");   
    }

    i++;
}

void Examination(float[] arr)
{
    int i = 0;
    if (arr[i]<arr[i+1]+arr[i+2] && arr[i+1]<arr[i]+arr[i+2] && arr[i+2]<arr[i]+arr[i+1])
    Calculations(arr);
    else Console.WriteLine ("Нельзя построить треугольник с данными сторонами");
}

void Calculations(float[] arr)
{
    Console.WriteLine ("Можно построить треугольник с данными сторонами");
    Console.WriteLine ("Его периметр: P = " + (arr[0]+arr[1]+arr[2]));
    float Pp = (arr[0]+arr[1]+arr[2])/2;                                                         //полупериметр
    double S = Math.Sqrt(Pp*(Pp-arr[0])*(Pp-arr[1])*(Pp-arr[2]));                                //Площадь треугольника по формуле Герона
    Console.WriteLine ("Его площадь: S = " + Math.Round(S, 2, MidpointRounding.AwayFromZero));

    double cornerA = ((arr[0]*arr[0]+arr[2]*arr[2]-arr[1]*arr[1])/(2*arr[0]*arr[2]));
    double cornerA2 = (double)Math.Acos(cornerA)*(180.0 / Math.PI);
    double cornerA3 = Math.Round(cornerA2, 2, MidpointRounding.AwayFromZero);

    double cornerB = ((arr[0]*arr[0]+arr[1]*arr[1]-arr[2]*arr[2])/(2*arr[0]*arr[1]));
    double cornerB2 = (double)Math.Acos(cornerB)*(180.0 / Math.PI);
    double cornerB3 = Math.Round(cornerB2, 2, MidpointRounding.AwayFromZero);

    double cornerC3 = Math.Round(180 - cornerA2 - cornerB2, 2, MidpointRounding.AwayFromZero);

    Console.WriteLine ($"Углы треугольника в градусах: {cornerA3}; {cornerB3}; {cornerC3};");
    
    if (cornerA3==90 || cornerB3==90 || cornerC3==90)  Console.WriteLine ("Треугольник прямоугольный");
    else Console.WriteLine ("Треугольник не прямоугольный");

    if (arr[0]==arr[1] || arr[0]==arr[2] || arr[1]==arr[2])  Console.WriteLine ("Треугольник равнобедренный");
    else Console.WriteLine ("Треугольник не равнобедренный");

    if (arr[0]==arr[1] && arr[1]==arr[2])  Console.WriteLine ("Треугольник равносторонний");
    else Console.WriteLine ("Треугольник не равносторонний");
}

Console.WriteLine ();
Examination(arr);
