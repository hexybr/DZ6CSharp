// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.WriteLine("Введите k1: ");
double k1 = double.Parse(Console.ReadLine()!); // Ввод значений
Console.WriteLine("Введите k2: ");
double k2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите b1: ");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите b2: ");
double b2 = double.Parse(Console.ReadLine()!);
Check(k1,k2,b1,b2);

void Check(double k1,double k2,double b1,double b2) // функция проверки на возможные пересечения
{
    if (k1 != k2)
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Пересечение в точке:({x};{y})");
    }
    if (k1 == k2 && b1 != b2)
    {
        Console.WriteLine("Прямые параллельны");
    }
    if (k1 == k2 && b1 == b2)
    {
        Console.WriteLine("Прямые совпадают");
    }
}