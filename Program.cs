//Задача 44: Не используя рекурсию,выведете первые N чисел Фибоначчи .Первые два числа Фибоначчи : 0 , 1.
Console.Clear();
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
ulong[] Fibonachi(int number)
{
    int temp = 2;
    ulong[] result = new ulong[number];
    result[0] = 0;
    result[1] = 1;
    Console.Write($"Если N = {number}  - > {result[0]}  {result[1]} ");
    while (temp < number)
    {
        result[temp] = result[temp - 1] + result[temp - 2];
        Console.Write($" {result[temp]} ");
        temp++;
    }
    return result;
}

ulong MaxInFibonachi(ulong[] arra)
{
    ulong max = 0;
    ulong min = arra[0];
    for (int g = 0; g < arra.Length; g++)
    {
        if (min > arra[g]) min = arra[g];
        else max = arra[g];
    }
    Console.WriteLine($"  Максимальное число-> {max}");
    return max;
}
ulong[] a = Fibonachi(N);
Console.WriteLine("      ");
MaxInFibonachi(a);