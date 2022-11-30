//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Введите числа через пробел: ");
Morethan0();

void Morethan0()
{
    int[] digits = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse); // Создает массив из вводимых с клавиатуры значений.
    int counter = 0;
    for (int i = 0; i < digits.Length; i++)
    {
        if (digits[i] > 0)
            counter++;
    }
    Console.WriteLine("Количество чисел больше 0 = " + counter);
}





//void EnteringNumbers()                                // Введение числа элементов
// {
//     int[] firstMas = new int[0];
//     while (true)
//     {
//         string userInput = Console.ReadLine()!;
//         if (userInput == "end")
//         {
//             break;
//         }
//         else if (userInput == "sum")
//         {
//             int counter = 0;
//             for (int i = 0; i < firstMas.Length; i++)
//                 if (firstMas[i] > 0)
//                     counter++;
//             Console.WriteLine("Количество чисел больше 0 = " + counter);
//         }
//         else
//         {
//             int[] secondMas = new int[firstMas.Length + 1];
//             int number = Convert.ToInt32(userInput);
//             secondMas[secondMas.Length - 1] = number;
//             for (int i = 0; i < firstMas.Length; i++)
//                 secondMas[i] = firstMas[i];
//             firstMas = secondMas;
//         }
//     }
// }


