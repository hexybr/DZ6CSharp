// Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры). Вывести на экран красивенько таблицей. 
// Найти минимальное число и его индекс, найти максимальное число и его индекс, среднее арифметическое. Вывести эту информацию на экран.
Console.WriteLine("Введите количество строк:");
int rows;
if (!int.TryParse(Console.ReadLine()!, out rows))
{
    Console.WriteLine("Неверный ввод");
    return;
}
Console.WriteLine("Введите количество столбцов:");
int columns;
if (!int.TryParse(Console.ReadLine()!, out columns))
{
    Console.WriteLine("Неверный ввод");
    return;
}
int[,] array = new int[rows, columns];
FillArray(array);
PrintArray(array);
Check(array);

void FillArray(int[,] array)
{

    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int k = 0; k < columns; k++)
        {
            array[i, k] = rnd.Next(-100, 101);
        }
    }
}
void PrintArray(int[,] input)
{
    Console.WriteLine("Полученный массив: ");
    for (int i = 0; i < input.GetLength(0); i++)
    {
        for (int k = 0; k < input.GetLength(1); k++)
        {
            Console.Write(input[i, k] + " ");
        }
        Console.WriteLine();
    }

}
void Check(int[,] array)
{
    int max = array[0,0]; int min = array[0,0];
    int indmax1 = 0;int indmax2 = 0; int indmin1 = 0;int indmin2 = 0;
    float average = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            average += array[i, k];
            if (array[i, k] > max) 
            {
                max = array[i, k];
                indmax1 = i;
                indmax2 = k;
            }
            if (array[i,k] < min)
            {
                min = array[i,k];
                indmin1 = i;
                indmin2 = k;
            }
        }
    }
    average = average / array.Length;
    Console.WriteLine("Среднее арифметическое = " + average);
    Console.WriteLine($"Максимальный элемент = {max}. Его индекс = ({indmax1},{indmax2})");
    Console.WriteLine($"Минимальный элемент = {min}. Его индекс = ({indmin1},{indmin2})");
}