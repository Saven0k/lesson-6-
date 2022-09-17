// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
Console.Clear();
Console.Write("Введите число: ");
long a = long.Parse(Console.ReadLine());
Console.Clear();
Console.Write($"{a} ->");
long ten_in_two(long number)
{
    long result = 0;
    if (number > 0)
    {
        result = number % 2;
        number = number /2 ;
        Console.Write($" {result} ");
        number = ten_in_two(number);
    }
    else{}
    return result;
}
ten_in_two(a);
