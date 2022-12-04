//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Введите числа через пробел: ");
Morethan0();

void Morethan0()
{
    int[] digits = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse); // Создает массив из вводимых с клавиатуры значений.
    int counter = 0;                                                         // На написание этой строчки понадобилось N-ое количество часов
    for (int i = 0; i < digits.Length; i++)
    {
        if (digits[i] > 0)
            counter++;
    }
    Console.WriteLine("Количество чисел больше 0 = " + counter);
}