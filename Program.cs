// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3
Console.Clear();
Console.Write("Введите числа: ");
int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
void bigger_than_ziro(int[] arra)
{
    int count = 0;
    foreach (int i in arra)
    {
        if (i > 0) count++;
        else{}
    }
    Console.Write($"-> {count}");
}

bigger_than_ziro(array);