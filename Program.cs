//Зачада 39

Console.Clear();
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    Console.Write("[ ");
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        if (i == size - 1) Console.Write($"{res[i]}");
        else Console.Write($"{res[i]} , ");
    }
    Console.Write("]");
    return res;
}

void PalindromArray(int[] arra)
{
    Console.Write(" -> [ ");
    for (int i = 0; i < arra.Length; i++)
    {
        if (arra[i] == arra[0])
        {
            int s1 = arra[i];
            arra[i] = arra[arra.Length - 1];
            arra[arra.Length - 1] = s1;
        }
        else if (arra[i] == arra[1])
        {
            int s2 = arra[i];
            arra[i] = arra[arra.Length - 2];
            arra[arra.Length - 2] = s2;
        }
        else { }
        if (arra[i] == arra[arra.Length - 1]) Console.Write($"{arra[i]}");
        else Console.Write($"{arra[i]} , ");
    }
    Console.Write("]");
}

void ReversArray(int[] arra)
{
    for (int i = 0; i < arra.Length / 2; i++)
    {
        int s3 = arra[i];
        arra[i] = arra[arra.Length - i - 1];
        arra[arra.Length - i - 1] = s3;
    }
}
int[] array = GetArray(10, 0, 10);
ReversArray(array);
Console.Write(" -> [ ");
Console.Write(String.Join(" , " ,  array));
Console.Write("]  ");



